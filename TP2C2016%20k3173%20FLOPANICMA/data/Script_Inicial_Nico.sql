/* ESQUEMA */
USE GD2C2016;
GO

CREATE SCHEMA FLOPANICMA AUTHORIZATION GD;
GO

/**************/
/* SECUENCIAS */
/**************/



/**********/
/* TABLAS */
/**********/

CREATE TABLE FLOPANICMA.PERSONA
(
		ID_PERSONA INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		NOMBRE VARCHAR(50) NOT NULL,
		APELLIDO VARCHAR(50) NOT NULL,
		DIRECCION VARCHAR(255) NULL,
		TELEFONO VARCHAR(50) NULL,
		E_MAIL VARCHAR(255) NOT NULL,
		F_NACIMIENTO DATE NULL,
		TIPO_DOCUMENTO VARCHAR(20) NULL,
		NRO_DOCUMENTO INT NOT NULL,
		SEXO VARCHAR(1) NOT NULL,
);

CREATE TABLE FLOPANICMA.PROFESIONAL
(
		ID_PROFESIONAL INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		ID_PERSONA INT NOT NULL,
		MATRICULA INT NOT NULL,
		HORAS_ACUMULADAS INT NOT NULL,
		
		CONSTRAINT FK_PROFESIONAL_PERSONA FOREIGN KEY (ID_PERSONA) REFERENCES FLOPANICMA.PERSONA(ID_PERSONA)
);

CREATE TABLE FLOPANICMA.AGENDA
(		
		ID_PROFESIONAL INT NOT NULL PRIMARY KEY,
		PERIODO_INICIO DATE,
		PERIODO_FIN DATE,
		
		CONSTRAINT FK_AGENDA_PROFESIONAL FOREIGN KEY (ID_PROFESIONAL) REFERENCES FLOPANICMA.PROFESIONAL(ID_PROFESIONAL)
);

CREATE TABLE FLOPANICMA.TIPO_ESPECIALIDAD
(
		ID_TIPO_ESPECIALIDAD INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		DETALLE VARCHAR(255) NULL
);

CREATE TABLE FLOPANICMA.ESPECIALIDAD
(
		ID_ESPECIALIDAD INT NOT NULL PRIMARY KEY,
		ID_TIPO_ESPECIALIDAD INT NOT NULL,
		DETALLE VARCHAR(255) NOT NULL,
		
		CONSTRAINT FK_ESPECIALIDAD_TIPO_ESPECIALIDAD FOREIGN KEY (ID_TIPO_ESPECIALIDAD) REFERENCES FLOPANICMA.TIPO_ESPECIALIDAD(ID_TIPO_ESPECIALIDAD)
);

CREATE TABLE FLOPANICMA.ACTIVIDAD_DIA
(
		ID_PROFESIONAL INT NOT NULL,
		DIA VARCHAR(10) NOT NULL, 
		HORA_INICIO TIME(0) NOT NULL,
		HORA_FIN TIME(0) NOT NULL,
		ID_ESPECIALIDAD INT NOT NULL,
		
		CONSTRAINT PK_ACTIVIDAD_DIA PRIMARY KEY(ID_PROFESIONAL,DIA,HORA_INICIO,HORA_FIN),
		CONSTRAINT FK_ACTIVIDAD_DIA_AGENDA FOREIGN KEY (ID_PROFESIONAL) REFERENCES FLOPANICMA.AGENDA(ID_PROFESIONAL),
		CONSTRAINT FK_ACTIVIDAD_DIA_ESPECIALIDAD FOREIGN KEY (ID_ESPECIALIDAD) REFERENCES FLOPANICMA.ESPECIALIDAD(ID_ESPECIALIDAD)
);

CREATE TABLE FLOPANICMA.PLAN_MEDICO
(
		ID_PLAN INT NOT NULL PRIMARY KEY,
		CUOTA NUMERIC(4,2),
		COSTO_CONSULTA NUMERIC(3,2),
		COSTO_FARMACIA NUMERIC(3,2)
);

CREATE TABLE FLOPANICMA.AFILIADO
(
		ID_AFILIADO INT NOT NULL PRIMARY KEY,
		PLAN_MEDICO INT NOT NULL,
		ACTIVO BIT NOT NULL DEFAULT 1,
		ESTADO_CIVIL VARCHAR(50) NOT NULL,
		CANTIDAD_HIJOS INT NOT NULL,
		NRO_CONSULTA INT NOT NULL,
		ID_PERSONA INT NOT NULL,
		
		CONSTRAINT FK_AFILIADO_PLAN_MEDICO FOREIGN KEY (PLAN_MEDICO) REFERENCES FLOPANICMA.PLAN_MEDICO(ID_PLAN),
		CONSTRAINT FK_AFILIADO_PERSONA FOREIGN KEY (ID_PERSONA) REFERENCES FLOPANICMA.PERSONA(ID_PERSONA)
);

CREATE TABLE FLOPANICMA.BONOS
(
		ID_OPERACION INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		PLAN_MEDICO INT NOT NULL,
		NUMERO_AFILIADO INT NOT NULL,
		CANTIDAD_BONOS INT,
		
		CONSTRAINT FK_BONOS_PLAN_MEDICO FOREIGN KEY (PLAN_MEDICO) REFERENCES FLOPANICMA.PLAN_MEDICO(ID_PLAN),
		CONSTRAINT FK_BONOS_AFILIADO FOREIGN KEY (NUMERO_AFILIADO) REFERENCES FLOPANICMA.AFILIADO(ID_AFILIADO)
);

CREATE TABLE FLOPANICMA.MODIFICACIONES
(
		ID_MODIFICACION INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		ID_AFILIADO INT NOT NULL,
		FECHA DATE NOT NULL,
		DETALLE VARCHAR(255) NOT NULL,
		PLAN_MEDICO_ANTERIOR INT NOT NULL,
		
		CONSTRAINT FK_MODIFICACIONES_AFILIADO FOREIGN KEY (ID_AFILIADO) REFERENCES FLOPANICMA.AFILIADO(ID_AFILIADO),
		CONSTRAINT FK_MODIFICACIONES_PLAN_MEDICO FOREIGN KEY (PLAN_MEDICO_ANTERIOR) REFERENCES FLOPANICMA.PLAN_MEDICO(ID_PLAN)
);

CREATE TABLE FLOPANICMA.ESPECIALIDAD_PROFESIONAL
(
		ID_PROFESIONAL INT NOT NULL,
		ID_ESPECIALIDAD INT NOT NULL,
		
		CONSTRAINT PK_ESPECIALIDAD_PROFESIONAL PRIMARY KEY (ID_PROFESIONAL,ID_ESPECIALIDAD),
		CONSTRAINT FK_ESPECIALIDAD_PROFESIONAL_ESPECIALIDAD FOREIGN KEY (ID_ESPECIALIDAD) REFERENCES FLOPANICMA.ESPECIALIDAD(ID_ESPECIALIDAD),
		CONSTRAINT FK_ESPECIALIDAD_PROFESIONAL_PROFESIONAL FOREIGN KEY (ID_PROFESIONAL) REFERENCES FLOPANICMA.PROFESIONAL(ID_PROFESIONAL)
);

CREATE TABLE FLOPANICMA.TIPO_CANCELACION
(
		ID_TIPO_CANCELACION INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
		DETALLE VARCHAR(255) NULL
);

CREATE TABLE FLOPANICMA.CANCELACIONES
(
		ID_CANCELACION INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		COD_TIPO_CANCELACION INT NOT NULL,
		
		CONSTRAINT FK_CANCELACION_TIPO_CANCELACION FOREIGN KEY (COD_TIPO_CANCELACION) REFERENCES FLOPANICMA.TIPO_CANCELACION(ID_TIPO_CANCELACION)
);

CREATE TABLE FLOPANICMA.CONSULTAS
(
		ID_CONSULTA INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		ID_PROFESIONAL INT NOT NULL,
		ID_AFILIADO INT NOT NULL,
		DIA DATE NOT NULL,
		HORA TIME(0) NOT NULL,
		SINTOMA VARCHAR(255) NOT NULL,
		DIAGNOSTICO VARCHAR(255) NOT NULL,
		
		CONSTRAINT FK_CONSULTAS_AFILIADO FOREIGN KEY (ID_AFILIADO) REFERENCES FLOPANICMA.AFILIADO(ID_AFILIADO),
		CONSTRAINT FK_CONSULTAS_PROFESIONAL FOREIGN KEY (ID_PROFESIONAL) REFERENCES FLOPANICMA.PROFESIONAL(ID_PROFESIONAL)
);

CREATE TABLE FLOPANICMA.FUNCIONALIDAD
(
		ID_FUNCIONALIDAD INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		DESCRIPCION VARCHAR(255),
);

CREATE TABLE FLOPANICMA.PEDIDO_TURNO
(
		ID_PEDIDO INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		FECHA DATE NOT NULL,
		HORARIO TIME(0) NOT NULL,
		ID_PROFESIONAL INT NOT NULL,
		ID_AFILIADO INT NOT NULL,
		ID_CANCELACION INT NULL,
		
		CONSTRAINT FK_PEDIDO_TURNO_PROFESIONAL FOREIGN KEY (ID_PROFESIONAL) REFERENCES FLOPANICMA.PROFESIONAL(ID_PROFESIONAL),
		CONSTRAINT FK_PEDIDO_TURNO_AFILIADO FOREIGN KEY (ID_AFILIADO) REFERENCES FLOPANICMA.AFILIADO(ID_AFILIADO),
		CONSTRAINT FK_PEDIDO_TURNO_CANCELACIONES FOREIGN KEY (ID_CANCELACION) REFERENCES FLOPANICMA.CANCELACIONES(ID_CANCELACION)
);

CREATE TABLE FLOPANICMA.ROL
(
		ID_ROL INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		DESCRIPCION VARCHAR(255) NULL,
		ACTIVO BIT NOT NULL
);

CREATE TABLE FLOPANICMA.USUARIO
(
		ID_USUARIO INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		ID_PERSONA INT NOT NULL,
		USERNAME VARCHAR(50) NOT NULL,
		PASSWORD VARCHAR(50) NOT NULL,
		INTENTOS INT NOT NULL,
		ACTIVO BIT NOT NULL,
		
		CONSTRAINT FK_USUARIO_PERSONA FOREIGN KEY(ID_PERSONA) REFERENCES FLOPANICMA.PERSONA(ID_PERSONA)
);

CREATE TABLE FLOPANICMA.USUARIO_ROL
(
		ID_USUARIO INT NOT NULL,
		ID_ROL INT NOT NULL,
		
		CONSTRAINT PK_USUARIO_ROL PRIMARY KEY (ID_USUARIO,ID_ROL),
		CONSTRAINT FK_USUARIO_ROL_USUARIO FOREIGN KEY (ID_USUARIO) REFERENCES FLOPANICMA.USUARIO(ID_USUARIO),
		CONSTRAINT FK_USUARIO_ROL_ROL FOREIGN KEY (ID_ROL) REFERENCES FLOPANICMA.ROL(ID_ROL)
);

CREATE TABLE FLOPANICMA.ROL_FUNCIONALIDAD
(
		ID_ROL INT NOT NULL,
		ID_FUNCIONALIDAD INT NOT NULL,
		
		CONSTRAINT PK_ROL_FUNCIONALIDAD PRIMARY KEY (ID_ROL,ID_FUNCIONALIDAD),
		CONSTRAINT FK_ROL_FUNCIONALIDAD_ROL FOREIGN KEY (ID_ROL) REFERENCES FLOPANICMA.ROL(ID_ROL),
		CONSTRAINT FK_ROL_FUNCIONALIDAD_FUNCIONALIDAD FOREIGN KEY (ID_FUNCIONALIDAD) REFERENCES FLOPANICMA.FUNCIONALIDAD(ID_FUNCIONALIDAD)
);


/***********/
/* INDICES */
/***********/



/***********************/
/* INSERTS DATOS FIJOS */
/***********************/



/************/
/* MIGRADOR */
/************/



/***********/
/* TRIGGERS */
/***********/



/******************/
/* ABMs y Filtros */
/******************/

