/* ESQUEMA */
USE GD2C2016;
GO

CREATE SCHEMA FLOPANICMA AUTHORIZATION GD;
GO

/**************/
/* SECUENCIAS */
/**************/

CREATE SEQUENCE FLOPANICMA.AFILIADO_SEQ START WITH 100 INCREMENT BY 100;
CREATE SEQUENCE FLOPANICMA.MATRICULA_SEQ START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE FLOPANICMA.PERSONA_SEQ AS INT START WITH 1 INCREMENT BY 1;


/**********/
/* TABLAS */
/**********/

CREATE TABLE FLOPANICMA.PERSONA
(
		ID_PERSONA INT NOT NULL PRIMARY KEY,
		NOMBRE VARCHAR(255) NULL,
		APELLIDO VARCHAR(255) NULL,
		DIRECCION VARCHAR(255) NULL,
		TELEFONO NUMERIC(18,0) NULL,
		E_MAIL VARCHAR(255) NOT NULL DEFAULT 'SIN E-MAIL',
		F_NACIMIENTO DATETIME NULL,
		TIPO_DOCUMENTO VARCHAR(20) NOT NULL DEFAULT 'DNI',
		NRO_DOCUMENTO NUMERIC(18,0) NULL,
		SEXO VARCHAR(1) NULL,
);

CREATE TABLE FLOPANICMA.PROFESIONAL
(
		ID_PROFESIONAL INT NOT NULL PRIMARY KEY,
		MATRICULA INT NOT NULL,
		HORAS_ACUMULADAS INT NOT NULL DEFAULT 0,
		
		CONSTRAINT FK_PROFESIONAL_PERSONA FOREIGN KEY (ID_PROFESIONAL) REFERENCES FLOPANICMA.PERSONA(ID_PERSONA)
);

CREATE TABLE FLOPANICMA.TIPO_ESPECIALIDAD
(
		ID_TIPO_ESPECIALIDAD NUMERIC(18,0) NOT NULL PRIMARY KEY,
		DETALLE VARCHAR(255) NULL
);

CREATE TABLE FLOPANICMA.ESPECIALIDAD
(
		ID_ESPECIALIDAD NUMERIC(18,0) NOT NULL PRIMARY KEY,
		ID_TIPO_ESPECIALIDAD NUMERIC(18,0) NOT NULL,
		DETALLE VARCHAR(255) NULL,
		
		CONSTRAINT FK_ESPECIALIDAD_TIPO_ESPECIALIDAD FOREIGN KEY (ID_TIPO_ESPECIALIDAD) REFERENCES FLOPANICMA.TIPO_ESPECIALIDAD(ID_TIPO_ESPECIALIDAD)
);

CREATE TABLE FLOPANICMA.AGENDA
(		
		ID_PROFESIONAL INT NOT NULL,
		DIA VARCHAR(10) NOT NULL,
		HORA_TURNO TIME(0) NOT NULL,
		ID_ESPECIALIDAD NUMERIC (18,0),
		PERIODO_INICIO DATE NOT NULL,
		PERIODO_FIN DATE NOT NULL,
		
		CONSTRAINT PK_AGENDA PRIMARY KEY (ID_PROFESIONAL,DIA,HORA_TURNO,ID_ESPECIALIDAD),
		CONSTRAINT FK_AGENDA_ESPECIALIDAD FOREIGN KEY (ID_ESPECIALIDAD) REFERENCES FLOPANICMA.ESPECIALIDAD(ID_ESPECIALIDAD),
		CONSTRAINT FK_AGENDA_PROFESIONAL FOREIGN KEY (ID_PROFESIONAL) REFERENCES FLOPANICMA.PROFESIONAL(ID_PROFESIONAL)
);

CREATE TABLE FLOPANICMA.PLAN_MEDICO
(
		ID_PLAN NUMERIC(18,0) NOT NULL PRIMARY KEY,
		DESCRIPCION VARCHAR(255)NULL,
		CUOTA NUMERIC(18,0) NULL,
		COSTO_CONSULTA NUMERIC(18,0) NULL,
		COSTO_FARMACIA NUMERIC(18,0) NULL
);

CREATE TABLE FLOPANICMA.AFILIADO
(
		ID_AFILIADO INT NOT NULL PRIMARY KEY,
		NRO_AFILIADO INT NOT NULL,
		PLAN_MEDICO NUMERIC(18,0) NOT NULL,
		ACTIVO BIT NOT NULL DEFAULT 1,
		ESTADO_CIVIL VARCHAR(50) NOT NULL DEFAULT 'SOLTERO/A',
		CANTIDAD_HIJOS INT NOT NULL DEFAULT 0,
		NRO_CONSULTA INT NOT NULL DEFAULT 0, 
		
		CONSTRAINT FK_AFILIADO_PLAN_MEDICO FOREIGN KEY (PLAN_MEDICO) REFERENCES FLOPANICMA.PLAN_MEDICO(ID_PLAN),
		CONSTRAINT FK_AFILIADO_PERSONA FOREIGN KEY (ID_AFILIADO) REFERENCES FLOPANICMA.PERSONA(ID_PERSONA)
);

CREATE TABLE FLOPANICMA.COMPRA_BONO
(
		ID_OPERACION INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		ID_AFILIADO INT NOT NULL,
		CANTIDAD_BONOS INT DEFAULT 1,
		FECHA_COMPRA DATETIME NOT NULL,
		FECHA_IMPRESION DATETIME NOT NULL,
		
		CONSTRAINT FK_COMPRA_BONO_AFILIADO FOREIGN KEY(ID_AFILIADO) REFERENCES FLOPANICMA.AFILIADO(ID_AFILIADO)
);

CREATE TABLE FLOPANICMA.BONO
(
		BONO_NRO NUMERIC(18,0) NOT NULL PRIMARY KEY,
		ID_OPERACION INT NOT NULL,
		PLAN_MEDICO NUMERIC(18,0) NOT NULL,
		NUMERO_AFILIADO INT NOT NULL,
		
		
		CONSTRAINT FK_BONO_COMRA_BONO FOREIGN KEY (ID_OPERACION) REFERENCES FLOPANICMA.COMPRA_BONO(ID_OPERACION),
		CONSTRAINT FK_BONOS_PLAN_MEDICO FOREIGN KEY (PLAN_MEDICO) REFERENCES FLOPANICMA.PLAN_MEDICO(ID_PLAN)
);

CREATE TABLE FLOPANICMA.MODIFICACION
(
		ID_MODIFICACION INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		ID_AFILIADO INT NOT NULL,
		FECHA DATE NOT NULL,
		DETALLE VARCHAR(255) NOT NULL,
		PLAN_MEDICO_ANTERIOR NUMERIC(18,0) NOT NULL,
		
		CONSTRAINT FK_MODIFICACIONES_AFILIADO FOREIGN KEY (ID_AFILIADO) REFERENCES FLOPANICMA.AFILIADO(ID_AFILIADO),
		CONSTRAINT FK_MODIFICACIONES_PLAN_MEDICO FOREIGN KEY (PLAN_MEDICO_ANTERIOR) REFERENCES FLOPANICMA.PLAN_MEDICO(ID_PLAN)
);

CREATE TABLE FLOPANICMA.ESPECIALIDAD_PROFESIONAL
(
		ID_PROFESIONAL INT NOT NULL,
		ID_ESPECIALIDAD NUMERIC(18,0) NOT NULL,
		
		CONSTRAINT PK_ESPECIALIDAD_PROFESIONAL PRIMARY KEY (ID_PROFESIONAL,ID_ESPECIALIDAD),
		CONSTRAINT FK_ESPECIALIDAD_PROFESIONAL_ESPECIALIDAD FOREIGN KEY (ID_ESPECIALIDAD) REFERENCES FLOPANICMA.ESPECIALIDAD(ID_ESPECIALIDAD),
		CONSTRAINT FK_ESPECIALIDAD_PROFESIONAL_PROFESIONAL FOREIGN KEY (ID_PROFESIONAL) REFERENCES FLOPANICMA.PROFESIONAL(ID_PROFESIONAL)
);

CREATE TABLE FLOPANICMA.PEDIDO_TURNO
(
		ID_TURNO NUMERIC(18,0) NOT NULL PRIMARY KEY,
		FECHA DATETIME NOT NULL,
		ID_PROFESIONAL INT NOT NULL,
		ID_AFILIADO INT NOT NULL,
		ID_ESPECIALIDAD NUMERIC(18,0) NOT NULL,
		
		
		--FALTA CONSTRAINT PARA EVITAR PEDIDOS A MAS DE UN DOCTOR Y DE UN DOCTOR A VARIOS PACIENTES
		CONSTRAINT FK_PEDIDO_TURNO_ESPECIALIDAD FOREIGN KEY (ID_ESPECIALIDAD) REFERENCES FLOPANICMA.ESPECIALIDAD(ID_ESPECIALIDAD),
		CONSTRAINT FK_PEDIDO_TURNO_PROFESIONAL FOREIGN KEY (ID_PROFESIONAL) REFERENCES FLOPANICMA.PROFESIONAL(ID_PROFESIONAL),
		CONSTRAINT FK_PEDIDO_TURNO_AFILIADO FOREIGN KEY (ID_AFILIADO) REFERENCES FLOPANICMA.AFILIADO(ID_AFILIADO),
);

CREATE TABLE FLOPANICMA.TIPO_CANCELACION
(
		ID_TIPO_CANCELACION INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
		DETALLE VARCHAR(255) NULL
);

CREATE TABLE FLOPANICMA.CANCELACION
(
		ID_TURNO_CANCELADO NUMERIC(18,0) NOT NULL PRIMARY KEY,
		COD_TIPO_CANCELACION INT NOT NULL,
		
		CONSTRAINT FK_CANCELACION_PEDIDO_TURNO FOREIGN KEY (ID_TURNO_CANCELADO) REFERENCES FLOPANICMA.PEDIDO_TURNO(ID_TURNO),
		CONSTRAINT FK_CANCELACION_TIPO_CANCELACION FOREIGN KEY (COD_TIPO_CANCELACION) REFERENCES FLOPANICMA.TIPO_CANCELACION(ID_TIPO_CANCELACION)
);

CREATE TABLE FLOPANICMA.CONSULTA
(
		ID_CONSULTA INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		ID_TURNO NUMERIC(18,0) NOT NULL,
		BONO_NRO NUMERIC(18,0) NOT NULL,
		SINTOMA VARCHAR(255) NULL,
		DIAGNOSTICO VARCHAR(255) NULL,
		REGISTRO_LLEGADA DATETIME NOT NULL,
		
		CONSTRAINT FK_CONSULTA_BONO FOREIGN KEY(BONO_NRO)REFERENCES FLOPANICMA.BONO(BONO_NRO),
		CONSTRAINT FK_CONSULTA_PEDIDO_TURNO FOREIGN KEY (ID_TURNO)REFERENCES FLOPANICMA.PEDIDO_TURNO(ID_TURNO)
);

CREATE TABLE FLOPANICMA.FUNCIONALIDAD
(
		ID_FUNCIONALIDAD INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		DESCRIPCION VARCHAR(255),
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
		USERNAME VARCHAR(255) NOT NULL,
		PASSWORD NVARCHAR(255) NOT NULL,
		INTENTOS INT NOT NULL DEFAULT 0,
		ACTIVO BIT NOT NULL DEFAULT 1,
		
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
CREATE UNIQUE INDEX NRO_DOCUMENTO_IND1 ON FLOPANICMA.PERSONA(NRO_DOCUMENTO);
CREATE UNIQUE INDEX USUARIO_IND1 ON FLOPANICMA.USUARIO(USERNAME);

/***********************/
/*      FUNCIONES      */
/***********************/
GO

CREATE FUNCTION FLOPANICMA.PASSWORD_HASH(@PASSWORD NVARCHAR(255))
	RETURNS NVARCHAR(255)
	
	BEGIN
		RETURN HASHBYTES('SHA2_256',@PASSWORD)
	END;

GO

CREATE FUNCTION FLOPANICMA.TRIM(@string VARCHAR(255))
	RETURNS VARCHAR(255)

	BEGIN
		RETURN LTRIM(RTRIM(@string))
	END

--FUNCION PARA DETERMINAR CANTIDAD DE TURNOS A REGISTRAR EN AGENDA

/************/
/* MIGRADOR */
/************/
GO

/*INSERTAR DATOS FIJOS*/
CREATE PROCEDURE FLOPANICMA.SP_MIGRACION_INSERT_DATOS_FIJOS
AS
BEGIN
	
	/*FLOPANICMA.ROL*/
	INSERT INTO FLOPANICMA.ROL(DESCRIPCION,ACTIVO)
	VALUES
	('ADMINISTRATIVO',1),
	('PROFESIONAL',1),
	('AFILIADO',1),
	('ADMINISTRADOR GENERAL',1);
	
	/*FLOPANICMA.FUNCIONALIDAD*/
	INSERT INTO FLOPANICMA.FUNCIONALIDAD(DESCRIPCION)
	VALUES
	('ABM DE AFILIADO'),
	('ABM DE ESPECIALIDADES MEDICAS'),
	('ABM DE PLANES MEDICOS'),
	('ABM DE PROFESIONAL'),
	('ABM DE ROL'),
	('CANCELAR ATENCION'),
	('COMPRA DE BONOS'),
	('LISTADOS'),
	('PEDIR TURNO'),
	('REGISTRAR AGENDA PROFESIONAL'),
	('REGISTRAR LLEGADA'),
	('REGISTRAR RESULTADO');
	
	/*FLOPLANICMA.ROL_FUNCIONALIDAD*/
	DECLARE @ID_ROL INT;
	DECLARE @ID_USUARIO INT;
	
	/*FUNCIONALIDADES DEL ROL ADMINISTRATIVO*/
	SELECT @ID_ROL = ID_ROL FROM FLOPANICMA.ROL WHERE DESCRIPCION='ADMINISTRATIVO';
	INSERT INTO FLOPANICMA.ROL_FUNCIONALIDAD (ID_ROL,ID_FUNCIONALIDAD)
	VALUES
	(@ID_ROL,(SELECT ID_FUNCIONALIDAD FROM FLOPANICMA.FUNCIONALIDAD WHERE DESCRIPCION = 'ABM DE AFILIADO')),
	(@ID_ROL,(SELECT ID_FUNCIONALIDAD FROM FLOPANICMA.FUNCIONALIDAD WHERE DESCRIPCION = 'ABM DE ESPECIALIDADES MEDICAS')),
	(@ID_ROL,(SELECT ID_FUNCIONALIDAD FROM FLOPANICMA.FUNCIONALIDAD WHERE DESCRIPCION ='ABM DE PLANES MEDICOS')),
	(@ID_ROL,(SELECT ID_FUNCIONALIDAD FROM FLOPANICMA.FUNCIONALIDAD WHERE DESCRIPCION ='ABM DE PROFESIONAL')),
	(@ID_ROL,(SELECT ID_FUNCIONALIDAD FROM FLOPANICMA.FUNCIONALIDAD WHERE DESCRIPCION ='ABM DE ROL')),
	(@ID_ROL,(SELECT ID_FUNCIONALIDAD FROM FLOPANICMA.FUNCIONALIDAD WHERE DESCRIPCION ='REGISTRAR LLEGADA'));
	
	/*FUNCIONALIDADES DEL ROL AFILIADO*/
	SELECT @ID_ROL = ID_ROL FROM FLOPANICMA.ROL WHERE DESCRIPCION='AFILIADO';
	INSERT INTO FLOPANICMA.ROL_FUNCIONALIDAD (ID_ROL,ID_FUNCIONALIDAD)
	VALUES
	(@ID_ROL,(SELECT ID_FUNCIONALIDAD FROM FLOPANICMA.FUNCIONALIDAD WHERE DESCRIPCION ='CANCELAR ATENCION')),
	(@ID_ROL,(SELECT ID_FUNCIONALIDAD FROM FLOPANICMA.FUNCIONALIDAD WHERE DESCRIPCION ='COMPRA DE BONOS')),
	(@ID_ROL,(SELECT ID_FUNCIONALIDAD FROM FLOPANICMA.FUNCIONALIDAD WHERE DESCRIPCION ='PEDIR TURNO'));
	
	/*FUNCIONALIDADES DEL ROL PROFESIONAL*/
	SELECT @ID_ROL = ID_ROL FROM FLOPANICMA.ROL WHERE DESCRIPCION='PROFESIONAL';
	INSERT INTO FLOPANICMA.ROL_FUNCIONALIDAD (ID_ROL,ID_FUNCIONALIDAD)
	VALUES
	(@ID_ROL,(SELECT ID_FUNCIONALIDAD FROM FLOPANICMA.FUNCIONALIDAD WHERE DESCRIPCION ='REGISTRAR AGENDA PROFESIONAL')),
	(@ID_ROL,(SELECT ID_FUNCIONALIDAD FROM FLOPANICMA.FUNCIONALIDAD WHERE DESCRIPCION ='CANCELAR ATENCION')),
	(@ID_ROL,(SELECT ID_FUNCIONALIDAD FROM FLOPANICMA.FUNCIONALIDAD WHERE DESCRIPCION ='REGISTRAR RESULTADO'));
	
	/*FUNCIONALIDADES DEL ROL ADMINISTRADOR GENERAL*/
	SELECT @ID_ROL = ID_ROL FROM FLOPANICMA.ROL WHERE DESCRIPCION='ADMINISTRADOR GENERAL';
	INSERT INTO FLOPANICMA.ROL_FUNCIONALIDAD(ID_ROL,ID_FUNCIONALIDAD)
	VALUES
	(@ID_ROL,(SELECT ID_FUNCIONALIDAD FROM FLOPANICMA.FUNCIONALIDAD WHERE DESCRIPCION = 'ABM DE AFILIADO')),
	(@ID_ROL,(SELECT ID_FUNCIONALIDAD FROM FLOPANICMA.FUNCIONALIDAD WHERE DESCRIPCION = 'ABM DE ESPECIALIDADES MEDICAS')),
	(@ID_ROL,(SELECT ID_FUNCIONALIDAD FROM FLOPANICMA.FUNCIONALIDAD WHERE DESCRIPCION ='ABM DE PLANES MEDICOS')),
	(@ID_ROL,(SELECT ID_FUNCIONALIDAD FROM FLOPANICMA.FUNCIONALIDAD WHERE DESCRIPCION ='ABM DE PROFESIONAL')),
	(@ID_ROL,(SELECT ID_FUNCIONALIDAD FROM FLOPANICMA.FUNCIONALIDAD WHERE DESCRIPCION ='ABM DE ROL')),
	(@ID_ROL,(SELECT ID_FUNCIONALIDAD FROM FLOPANICMA.FUNCIONALIDAD WHERE DESCRIPCION ='REGISTRAR LLEGADA')),
	(@ID_ROL,(SELECT ID_FUNCIONALIDAD FROM FLOPANICMA.FUNCIONALIDAD WHERE DESCRIPCION ='CANCELAR ATENCION')),
	(@ID_ROL,(SELECT ID_FUNCIONALIDAD FROM FLOPANICMA.FUNCIONALIDAD WHERE DESCRIPCION ='COMPRA DE BONOS')),
	(@ID_ROL,(SELECT ID_FUNCIONALIDAD FROM FLOPANICMA.FUNCIONALIDAD WHERE DESCRIPCION ='PEDIR TURNO')),
	(@ID_ROL,(SELECT ID_FUNCIONALIDAD FROM FLOPANICMA.FUNCIONALIDAD WHERE DESCRIPCION ='REGISTRAR AGENDA PROFESIONAL')),
	(@ID_ROL,(SELECT ID_FUNCIONALIDAD FROM FLOPANICMA.FUNCIONALIDAD WHERE DESCRIPCION ='REGISTRAR RESULTADO'));
	
	/*FLOPANICMA.TIPO_CANCELACION*/
	INSERT INTO FLOPANICMA.TIPO_CANCELACION(DETALLE)
	VALUES
	('CANCELACION DEL PACIENTE'),
	('CANCELACION DEL PROFESIONAL UN PERIODO'),
	('CANCELACION DEL PROFESIONAL DIA ENTERO'),
	('CANCELACION AFILIADO DADO DE BAJA');
	
	/*USUARIOS ADMINISTRATIVOS (FUNCIONALIDADES CORRESPONDIENTRES PARA ROL ADMINISTRATIVO*/
	INSERT INTO FLOPANICMA.PERSONA (ID_PERSONA,NOMBRE,NRO_DOCUMENTO)
	VALUES (NEXT VALUE FOR FLOPANICMA.PERSONA_SEQ,'ADMINISTRATIVO 1',32947431);
	
	INSERT INTO FLOPANICMA.USUARIO (ID_PERSONA,USERNAME,PASSWORD)
	VALUES ((SELECT ID_PERSONA FROM FLOPANICMA.PERSONA WHERE NOMBRE='ADMINISTRATIVO 1'),'NICO',FLOPANICMA.PASSWORD_HASH('W23E'));
	
	SELECT @ID_USUARIO = ID_USUARIO
	FROM FLOPANICMA.USUARIO
	WHERE USERNAME='NICO'
	
	INSERT INTO USUARIO_ROL
	VALUES (@ID_USUARIO,1)
	
	/*USUARIO ADMINISTRADOR (TODAS LAS FUNCIONALIDADES)*/
		
	INSERT INTO FLOPANICMA.PERSONA (ID_PERSONA,NOMBRE)
	VALUES (0,'ADMINISTRADOR GENERAL');
	
	INSERT INTO FLOPANICMA.USUARIO (ID_PERSONA,USERNAME,PASSWORD)
	VALUES (0,'ADMIN',FLOPANICMA.PASSWORD_HASH('w23e'));
	
	SELECT @ID_USUARIO=ID_USUARIO
	FROM FLOPANICMA.USUARIO 
	WHERE USERNAME = 'ADMIN';
		
	INSERT INTO USUARIO_ROL
	VALUES (@ID_USUARIO,@ID_ROL);

END;

GO

EXEC FLOPANICMA.SP_MIGRACION_INSERT_DATOS_FIJOS;

GO

/*MIGRAR AFILIADOS Y PLANES MEDICOS*/

CREATE PROCEDURE FLOPANICMA.SP_MIGRACION_AFILIADOS
AS
BEGIN
	DECLARE @MIGRA_AFILIADO_PLAN_MEDICO TABLE
	(
		NRO_DOCUMENTO NUMERIC(18,0) NULL,
		NOMBRE VARCHAR(255) NULL,
		APELLIDO VARCHAR(255) NULL,
		DIRECCION VARCHAR(255) NULL,
		TELEFONO NUMERIC(18,0) NULL,
		E_MAIL VARCHAR(255) NOT NULL DEFAULT 'SIN E-MAIL',
		F_NACIMIENTO DATETIME NULL,
		TIPO_DOCUMENTO VARCHAR(20) NOT NULL DEFAULT 'DNI',
		ID_PLAN NUMERIC(18,0) NULL,
		DESCRIPCION VARCHAR (255) NULL,
		CUOTA NUMERIC(4,2) NULL,
		COSTO_CONSULTA NUMERIC(18,0) NULL,
		COSTO_FARMACIA NUMERIC(18,0) NULL
	);
		
	INSERT INTO @MIGRA_AFILIADO_PLAN_MEDICO
	(NRO_DOCUMENTO,NOMBRE,APELLIDO,DIRECCION,TELEFONO,E_MAIL,F_NACIMIENTO,ID_PLAN,DESCRIPCION,COSTO_CONSULTA,COSTO_FARMACIA)
	SELECT DISTINCT (PACIENTE_DNI),PACIENTE_NOMBRE,PACIENTE_APELLIDO,PACIENTE_DIRECCION,PACIENTE_TELEFONO,PACIENTE_MAIL,
			PACIENTE_FECHA_NAC,PLAN_MED_CODIGO,PLAN_MED_DESCRIPCION,PLAN_MED_PRECIO_BONO_CONSULTA,PLAN_MED_PRECIO_BONO_FARMACIA
	FROM GD_ESQUEMA.MAESTRA
	WHERE PACIENTE_DNI IS NOT NULL;
	
	INSERT INTO FLOPANICMA.PLAN_MEDICO
	(ID_PLAN,DESCRIPCION,COSTO_CONSULTA,COSTO_FARMACIA)
	SELECT DISTINCT (ID_PLAN),DESCRIPCION,COSTO_CONSULTA,COSTO_FARMACIA
	FROM @MIGRA_AFILIADO_PLAN_MEDICO;
	
	INSERT INTO FLOPANICMA.PERSONA
	(ID_PERSONA,NOMBRE,APELLIDO,DIRECCION,TELEFONO,E_MAIL,F_NACIMIENTO,NRO_DOCUMENTO)
	SELECT NEXT VALUE FOR FLOPANICMA.PERSONA_SEQ,NOMBRE,APELLIDO,DIRECCION,TELEFONO,E_MAIL,F_NACIMIENTO,NRO_DOCUMENTO 
	FROM @MIGRA_AFILIADO_PLAN_MEDICO;
	
	INSERT INTO FLOPANICMA.AFILIADO 
	(NRO_AFILIADO,PLAN_MEDICO,ID_AFILIADO)
	SELECT ((NEXT VALUE FOR FLOPANICMA.AFILIADO_SEQ) + 1), ID_PLAN,
		   (SELECT ID_PERSONA FROM FLOPANICMA.PERSONA AS PERSTAB WHERE PERSTAB.NRO_DOCUMENTO=VARTAB.NRO_DOCUMENTO)
	FROM @MIGRA_AFILIADO_PLAN_MEDICO AS VARTAB;
	
	/*USUARIO AFILIADO (FUNCIONALIDADES CORRESPONDIENTES AL ROL AFILIADO)*/
	
	INSERT INTO FLOPANICMA.USUARIO
	(ID_PERSONA,USERNAME,PASSWORD)
	VALUES (4400,'AFIL1',FLOPANICMA.PASSWORD_HASH('w23e'));
	
	INSERT INTO FLOPANICMA.USUARIO_ROL
	(ID_USUARIO,ID_ROL)
	VALUES ((SELECT ID_USUARIO FROM FLOPANICMA.USUARIO WHERE USERNAME = 'AFIL1'),3);
	
END;
GO

EXEC FLOPANICMA.SP_MIGRACION_AFILIADOS;
		
GO

/*MIGRAR PROFESIONALES*/

CREATE PROCEDURE FLOPANICMA.SP_MIGRACION_PROFESIONALES
AS
BEGIN
	
	DECLARE @MIGRA_PROFESIONAL TABLE
	(
		NOMBRE VARCHAR(255),
		APELLIDO VARCHAR(255),
		NRO_DOCUMENTO NUMERIC(18,0),
		DIRECCION VARCHAR(255),
		TELEFONO NUMERIC(18,0),
		E_MAIL VARCHAR(255),
		F_NACIMIENTO DATETIME
	);
	
	INSERT INTO @MIGRA_PROFESIONAL
	(NRO_DOCUMENTO,NOMBRE,APELLIDO,DIRECCION,TELEFONO,E_MAIL,F_NACIMIENTO)
	SELECT DISTINCT(MEDICO_DNI),MEDICO_NOMBRE,MEDICO_APELLIDO,MEDICO_DIRECCION,MEDICO_TELEFONO,MEDICO_MAIL,MEDICO_FECHA_NAC
	FROM GD_ESQUEMA.MAESTRA
	WHERE MEDICO_DNI IS NOT NULL;
	
	INSERT INTO FLOPANICMA.PERSONA
	(ID_PERSONA,NOMBRE,APELLIDO,DIRECCION,NRO_DOCUMENTO,TELEFONO,E_MAIL,F_NACIMIENTO)
	SELECT (NEXT VALUE FOR FLOPANICMA.PERSONA_SEQ), NOMBRE,APELLIDO,DIRECCION,NRO_DOCUMENTO,TELEFONO,E_MAIL,F_NACIMIENTO
	FROM @MIGRA_PROFESIONAL;
	
	INSERT INTO FLOPANICMA.PROFESIONAL
	(ID_PROFESIONAL,MATRICULA,HORAS_ACUMULADAS)
	SELECT (SELECT ID_PERSONA FROM FLOPANICMA.PERSONA AS PERSTAB WHERE PERSTAB.NRO_DOCUMENTO=VARTAB.NRO_DOCUMENTO),
			(NEXT VALUE FOR FLOPANICMA.MATRICULA_SEQ),40
	FROM @MIGRA_PROFESIONAL AS VARTAB;
	
	/*USUARIO PROFESIONAL (FUNCIONALIDADES CORRESPONDIENTES AL ROL PROFESIONAL)*/
	
	INSERT INTO FLOPANICMA.USUARIO
	(ID_PERSONA,USERNAME,PASSWORD)
	VALUES (5555,'PROF1',FLOPANICMA.PASSWORD_HASH('w23e'));
	
	INSERT INTO FLOPANICMA.USUARIO_ROL
	(ID_USUARIO,ID_ROL)
	VALUES ((SELECT ID_USUARIO FROM FLOPANICMA.USUARIO WHERE USERNAME = 'PROF1'),2);
	
END;

GO

EXEC FLOPANICMA.SP_MIGRACION_PROFESIONALES

GO

/*MIGRAR ESPECIALIDADES, TIPOS DE ESPECIALIDAD Y ESPECIALIDAD_PROFESIONAL*/

CREATE PROCEDURE FLOPANICMA.SP_MIGRACION_ESPECIALIDADES
AS
BEGIN
	DECLARE @MIGRA_ESPECIALIDADES TABLE
	(
		ID_ESPECIALIDAD NUMERIC(18,0),
		ESP_DETALLE VARCHAR(255),
		ID_TIPO_ESPECIALIDAD NUMERIC(18,0),
		TIPO_ESP_DETALLE VARCHAR(255)
	);
	
	INSERT INTO @MIGRA_ESPECIALIDADES
	(ID_ESPECIALIDAD,ESP_DETALLE,ID_TIPO_ESPECIALIDAD,TIPO_ESP_DETALLE)
	SELECT DISTINCT(ESPECIALIDAD_CODIGO),ESPECIALIDAD_DESCRIPCION,TIPO_ESPECIALIDAD_CODIGO,TIPO_ESPECIALIDAD_DESCRIPCION
	FROM GD_ESQUEMA.MAESTRA;

	INSERT INTO FLOPANICMA.TIPO_ESPECIALIDAD
	(ID_TIPO_ESPECIALIDAD,DETALLE)
	SELECT DISTINCT(ID_TIPO_ESPECIALIDAD),TIPO_ESP_DETALLE
	FROM @MIGRA_ESPECIALIDADES
	WHERE ID_TIPO_ESPECIALIDAD IS NOT NULL;
	
	INSERT INTO FLOPANICMA.ESPECIALIDAD
	(ID_ESPECIALIDAD,ID_TIPO_ESPECIALIDAD,DETALLE)
	SELECT DISTINCT(ID_ESPECIALIDAD),ID_TIPO_ESPECIALIDAD,ESP_DETALLE
	FROM @MIGRA_ESPECIALIDADES
	WHERE ID_ESPECIALIDAD IS NOT NULL;
	
	INSERT INTO FLOPANICMA.ESPECIALIDAD_PROFESIONAL
	(ID_PROFESIONAL,ID_ESPECIALIDAD)
	SELECT DISTINCT FLOPANICMA.PROFESIONAL.ID_PROFESIONAL,GD_ESQUEMA.MAESTRA.ESPECIALIDAD_CODIGO
	FROM FLOPANICMA.PERSONA JOIN
         FLOPANICMA.PROFESIONAL ON FLOPANICMA.PERSONA.ID_PERSONA = FLOPANICMA.PROFESIONAL.ID_PROFESIONAL JOIN
         GD_ESQUEMA.MAESTRA ON FLOPANICMA.PERSONA.NRO_DOCUMENTO = GD_ESQUEMA.MAESTRA.MEDICO_DNI;
END;

GO

EXEC FLOPANICMA.SP_MIGRACION_ESPECIALIDADES;

GO


/*MIGRAR CONSULTAS, BONOS Y COMPRA DE BONOS*/

CREATE PROCEDURE FLOPANICMA.SP_MIGRACION_CONSULTAS_BONOS
AS
BEGIN
	DECLARE @MIGRA_CONSULTAS TABLE
	(
		ID_AFILIADO INT,
		ID_PROFESIONAL INT,
		ID_ESPECIALIDAD NUMERIC(18,0),
		FECHA_TURNO DATETIME,
		NRO_TURNO NUMERIC(18,0),
		FECHA_COMPRA DATETIME,
		FECHA_IMPRESION DATETIME,
		BONO_NUMERO NUMERIC (18,0),
		SINTOMA VARCHAR (255),
		ENFERMEDAD VARCHAR (255)
	);
	
	DECLARE @CB TABLE
	(
		ID_OPERACION INT IDENTITY(1,1),
		ID_AFILIADO INT,
		NRO_BONO NUMERIC(18,0),
		FECHA_COMPRA DATETIME,
		FECHA_IMPRESION DATETIME
	);
	
	DECLARE @CANTIDAD_CONSULTAS TABLE
	(
		AFILIADO NUMERIC (18,0),
		CANTIDAD INT
	);
	
	INSERT INTO @MIGRA_CONSULTAS
	(ID_AFILIADO,ID_PROFESIONAL,ID_ESPECIALIDAD,FECHA_TURNO,NRO_TURNO,FECHA_COMPRA,FECHA_IMPRESION,SINTOMA,ENFERMEDAD,BONO_NUMERO)
	SELECT (SELECT ID_PERSONA FROM FLOPANICMA.PERSONA AS PERTAB WHERE PERTAB.NRO_DOCUMENTO=GD_ESQUEMA.MAESTRA.PACIENTE_DNI),
	        (SELECT ID_PERSONA FROM FLOPANICMA.PERSONA AS PERTAB WHERE PERTAB.NRO_DOCUMENTO=GD_ESQUEMA.MAESTRA.MEDICO_DNI),
			ESPECIALIDAD_CODIGO,TURNO_FECHA,TURNO_NUMERO,COMPRA_BONO_FECHA,BONO_CONSULTA_FECHA_IMPRESION,
			CONSULTA_SINTOMAS,CONSULTA_ENFERMEDADES,BONO_CONSULTA_NUMERO 
	FROM GD_ESQUEMA.MAESTRA;
	
	INSERT INTO FLOPANICMA.PEDIDO_TURNO
	(ID_TURNO,FECHA,ID_PROFESIONAL,ID_AFILIADO,ID_ESPECIALIDAD)
	SELECT NRO_TURNO,FECHA_TURNO,ID_PROFESIONAL,ID_AFILIADO,ID_ESPECIALIDAD
	FROM @MIGRA_CONSULTAS
	WHERE (SINTOMA IS NULL AND FECHA_COMPRA IS NULL AND NRO_TURNO IS NOT NULL);
	
	INSERT INTO @CB
	(ID_AFILIADO,NRO_BONO,FECHA_COMPRA,FECHA_IMPRESION)
	SELECT ID_AFILIADO,BONO_NUMERO,FECHA_COMPRA,FECHA_IMPRESION
	FROM @MIGRA_CONSULTAS AS MIGCON
	WHERE MIGCON.FECHA_TURNO IS NULL;
	
	INSERT INTO FLOPANICMA.COMPRA_BONO
	(ID_AFILIADO,FECHA_COMPRA,FECHA_IMPRESION)
	SELECT ID_AFILIADO,FECHA_COMPRA,FECHA_IMPRESION
	FROM @CB;
	
	INSERT INTO FLOPANICMA.BONO
	(ID_OPERACION, PLAN_MEDICO,NUMERO_AFILIADO,BONO_NRO)
	SELECT ID_OPERACION,PLAN_MEDICO,NRO_AFILIADO,NRO_BONO
	FROM @CB AS CB JOIN FLOPANICMA.AFILIADO AS AFITAB ON CB.ID_AFILIADO = AFITAB.ID_AFILIADO;
	
	INSERT INTO FLOPANICMA.CONSULTA
	(ID_TURNO,BONO_NRO,SINTOMA,DIAGNOSTICO)
	SELECT NRO_TURNO,BONO_NUMERO,SINTOMA,ENFERMEDAD
	FROM @MIGRA_CONSULTAS
	WHERE FECHA_COMPRA IS NULL AND FECHA_IMPRESION IS NOT NULL
		
	INSERT INTO @CANTIDAD_CONSULTAS
	(AFILIADO,CANTIDAD)
	SELECT DISTINCT(ID_AFILIADO),COUNT(CONTAB.ID_TURNO)
	FROM FLOPANICMA.CONSULTA AS CONTAB JOIN FLOPANICMA.PEDIDO_TURNO AS PEDTAB ON CONTAB.ID_TURNO = PEDTAB.ID_TURNO
	GROUP BY (ID_AFILIADO);
	
	UPDATE FLOPANICMA.AFILIADO
	SET NRO_CONSULTA = (SELECT CANTIDAD FROM @CANTIDAD_CONSULTAS WHERE ID_AFILIADO = AFILIADO);
	
END;
GO

EXEC FLOPANICMA.SP_MIGRACION_CONSULTAS_BONOS

GO

CREATE PROCEDURE FLOPANICMA.SP_MIGRACION_AGENDA
AS
BEGIN
		
	INSERT INTO FLOPANICMA.AGENDA
	(ID_PROFESIONAL,DIA,HORA_TURNO,ID_ESPECIALIDAD,PERIODO_INICIO,PERIODO_FIN)
	SELECT DISTINCT PROTAB.ID_PROFESIONAL,DATENAME(DW,FECHA),CONVERT(TIME(0),FECHA),ESPTAB.ID_ESPECIALIDAD,'2015-01-01','2015-12-30'
	FROM FLOPANICMA.PROFESIONAL AS PROTAB JOIN 
		 FLOPANICMA.ESPECIALIDAD_PROFESIONAL AS ESPTAB ON PROTAB.ID_PROFESIONAL = ESPTAB.ID_PROFESIONAL JOIN
		 FLOPANICMA.PEDIDO_TURNO AS TURNOTAB ON ESPTAB.ID_PROFESIONAL = TURNOTAB.ID_PROFESIONAL;
	
END;

GO

EXEC FLOPANICMA.SP_MIGRACION_AGENDA;

GO

/***********/
/* TRIGGERS */
/***********/
 CREATE TRIGGER FLOPANICMA.TG_BAJA_AFILIADO ON FLOPANICMA.AFILIADO FOR UPDATE
AS 
DECLARE @AFILIADO int
IF UPDATE(ACTIVO)
 BEGIN
 /* inserta la modificación como "BAJA AFILIADO" en modificacion */
	INSERT INTO FLOPANICMA.MODIFICACION
	(ID_AFILIADO,FECHA,DETALLE,PLAN_MEDICO_ANTERIOR)
	SELECT ID_AFILIADO,GETDATE(),'BAJA AFILIADO',PLAN_MEDICO
	FROM INSERTED;


	SELECT @AFILIADO=ID_AFILIADO FROM INSERTED;
	print @AFILIADO;

	/* borra las consultas derivadas de los turnos y luego los turnos. Consultas porque pusimos un constraint en ID_TURNO entre ambas */
	DELETE FROM FLOPANICMA.CONSULTA
	WHERE ID_TURNO IN (SELECT con.ID_TURNO FROM FLOPANICMA.CONSULTA AS con INNER JOIN FLOPANICMA.PEDIDO_TURNO AS ped
	ON con.ID_TURNO = ped.ID_TURNO
	WHERE CONVERT(DATE,ped.FECHA) > GETDATE() and ped.ID_AFILIADO=@AFILIADO);

	DELETE FROM FLOPANICMA.PEDIDO_TURNO
	WHERE CONVERT(DATE,FECHA) > GETDATE() and ID_AFILIADO=@AFILIADO;

END

GO 
 
 GO 
 
 CREATE TRIGGER FLOPANICMA.TG_GENERAR_BONOS ON FLOPANICMA.COMPRA_BONO FOR INSERT
 AS
 BEGIN TRANSACTION
	DECLARE @NRO_AFILIADO INT;
	DECLARE @CANTIDAD INT;
	DECLARE @ID_AFILIADO INT;
	DECLARE @NRO_CONSULTA INT;
	DECLARE @PLAN_MEDICO NUMERIC(18,0);
	
	SET @ID_AFILIADO = (SELECT ID_AFILIADO FROM INSERTED);
	
	SET @NRO_AFILIADO = (SELECT NUMERO_AFILIADO FROM FLOPANICMA.AFILIADO WHERE ID_AFILIADO = @ID_AFILIADO); --PERMITIR NULL
	
	SET @NRO_CONSULTA = (SELECT NRO_CONSULTA FROM FLOPANICMA.AFILIADO WHERE ID_AFILIADO = @ID_AFILIADO);
	
	SET @CANTIDAD = (SELECT CANTIDAD_BONOS FROM INSERTED);
	
	SET @PLAN_MEDICO=(SELECT PLAN_MEDICO FROM FLOPANICMA.AFILIADO WHERE ID_AFILIADO=@ID_AFILIADO);

	WHILE @CANTIDAD >0
	BEGIN
		INSERT INTO FLOPANICMA.BONO
		(BONO_NRO,ID_OPERACION,PLAN_MEDICO,NUMERO_AFILIADO)
		SELECT ((@NRO_AFILIADO *10000)+@NRO_CONSULTA),ID_OPERACION,@PLAN_MEDICO,@NRO_AFILIADO
		FROM INSERTED;
		SET @CANTIDAD = @CANTIDAD - 1;
	END
COMMIT

GO

CREATE TRIGGER FLOPANICMA.TG_QUITAR_ROL_INACTIVO_USUARIOS ON FLOPANICMA.ROL
FOR UPDATE
AS
IF UPDATE(ACTIVO)
BEGIN TRANSACTION
	DELETE USUARIO_ROL
	FROM FLOPANICMA.USUARIO_ROL USUARIO_ROL
	INNER JOIN FLOPANICMA.ROL ROL
		ON ROL.ID_ROL = USUARIO_ROL.ID_ROL
	AND ROL.ACTIVO = 0;
COMMIT

GO

/******************/
/* ABMs y Filtros */
/******************/

/*VALIDA EL USUARIO Y SU CONTRASEÑA VERIFICANDO QUE SE HAYAN CARGADO LOS DATOS E INHABILITANDO
 AL USUARIO SI SUPERA LOS TRES INTENTOS ERRONEOS DE CONTRASEÑA*/
 
CREATE PROCEDURE FLOPANICMA.LOGIN_USUARIO
@USERNAME VARCHAR(255),
@PASSWORD NVARCHAR(255),
@ID_USUARIO INT OUTPUT,
@ID_ERROR BIT OUTPUT,
@DESC_ERROR VARCHAR(255) OUTPUT

AS
BEGIN
	
	DECLARE @INTENTOS INT;
	DECLARE @HASH_PASS NVARCHAR(255);
	
	SET @ID_ERROR=0;
	SET @DESC_ERROR='';
	SET @ID_USUARIO=0;
	
	SET @USERNAME = FLOPANICMA.TRIM(UPPER(@USERNAME));
	
	IF (@USERNAME IS NULL OR @USERNAME='')
	BEGIN
		SET @ID_ERROR = 1;
		SET @DESC_ERROR = 'Debe ingresar un usuario';
		RETURN;
	END
	
	IF ((SELECT ID_USUARIO FROM FLOPANICMA.USUARIO AS USERTAB WHERE USERTAB.USERNAME = @USERNAME) IS NULL)
	BEGIN
		SET @ID_ERROR = 1;
		SET @DESC_ERROR = 'El usuario ingresado no existe';
		RETURN;
	END
	
	IF ((SELECT ACTIVO FROM FLOPANICMA.USUARIO AS USERTAB WHERE USERTAB.USERNAME=@USERNAME) = 0)
	BEGIN
		SET @ID_ERROR = 1;
		SET @DESC_ERROR = 'Este usuario se encuentra bloqueado. Contacte a un administrador';
		RETURN;
	END
	
	SET @HASH_PASS = FLOPANICMA.PASSWORD_HASH(@PASSWORD);
	
	IF ((SELECT PASSWORD FROM FLOPANICMA.USUARIO AS USERTAB WHERE USERTAB.USERNAME=@USERNAME)<>@HASH_PASS)
	  BEGIN
		  SET @ID_ERROR = 1;
		  SET @DESC_ERROR = 'La constraseña ingresada es incorrecta';
		
		  SELECT @INTENTOS = INTENTOS FROM FLOPANICMA.USUARIO AS USERTAB WHERE USERTAB.USERNAME=@USERNAME;
		  SET @INTENTOS = @INTENTOS +1;
		  
		  UPDATE FLOPANICMA.USUARIO
		  SET INTENTOS = @INTENTOS
		  WHERE USERNAME= @USERNAME;
	  END
	 ELSE
	  BEGIN
		    SELECT @ID_USUARIO = ID_USUARIO FROM FLOPANICMA.USUARIO AS USERTAB WHERE USERTAB.USERNAME=@USERNAME;

			UPDATE FLOPANICMA.USUARIO
			SET INTENTOS = 0
			WHERE USERNAME = @USERNAME;
			RETURN;
	  END
	
	IF (@INTENTOS = 3)
		BEGIN
			SET @DESC_ERROR = 'La contraseña ingresada es incorrecta. Usuario bloqueado';
			
			UPDATE FLOPANICMA.USUARIO
			SET ACTIVO = 0
			WHERE USERNAME=@USERNAME;
			RETURN;
		END
	
	RETURN;
END;

GO

/*ASIGNAR ROLES POR USUARIO*/

CREATE PROCEDURE FLOPANICMA.GET_ROLES_POR_USUARIO 
@USERNAME VARCHAR(255),
@ID_ERROR INT OUTPUT,
@DESC_ERROR VARCHAR(255) OUTPUT
AS
BEGIN
	DECLARE @CANTIDAD INT;

	SELECT @ID_ERROR = 0;
	SELECT @DESC_ERROR = '';

	SELECT @USERNAME = FLOPANICMA.TRIM(UPPER(@USERNAME));

	SELECT @CANTIDAD = COUNT(*) FROM FLOPANICMA.USUARIO
	WHERE USERNAME = @USERNAME;

	IF (@CANTIDAD IS NULL OR @CANTIDAD = 0)
	BEGIN
		SELECT @ID_ERROR = 1;
		SELECT @DESC_ERROR = 'El Usuario ingresado no existe.';
		RETURN;
	END	

	SELECT @CANTIDAD = COUNT(*) FROM FLOPANICMA.USUARIO_ROL UR, FLOPANICMA.USUARIO U
	WHERE U.ID_USUARIO = UR.ID_USUARIO
	AND U.USERNAME = @USERNAME;

	IF (@CANTIDAD IS NULL OR @CANTIDAD = 0)
	BEGIN
		SELECT @ID_ERROR = 1;
		SELECT @DESC_ERROR = 'El Usuario ingresado no tiene Roles asociados.';
		RETURN;
	END	

	SELECT R.ID_ROL, R.DESCRIPCION, R.ACTIVO 
	FROM FLOPANICMA.USUARIO_ROL UR, FLOPANICMA.USUARIO U, FLOPANICMA.ROL R
	WHERE U.ID_USUARIO = UR.ID_USUARIO
	AND R.ID_ROL = UR.ID_ROL
	AND U.USERNAME = @USERNAME;

END;

GO

/*RECUPERAR FUNCIONALIDADES DE LOS ROLES*/

CREATE PROCEDURE FLOPANICMA.GET_FUNCIONALIDADES_POR_ROL 
@DESCRIPCION VARCHAR(50),
@ID_ERROR INT OUTPUT,
@DESC_ERROR VARCHAR(255) OUTPUT
AS
BEGIN
	DECLARE @CANTIDAD INT;

	SELECT @ID_ERROR = 0;
	SELECT @DESC_ERROR = '';

	SELECT @DESCRIPCION = FLOPANICMA.TRIM(UPPER(@DESCRIPCION));

	SELECT @CANTIDAD = COUNT(*) FROM FLOPANICMA.ROL
	WHERE DESCRIPCION = @DESCRIPCION;

	IF (@CANTIDAD IS NULL OR @CANTIDAD = 0)
	BEGIN
		SELECT @ID_ERROR = 1;
		SELECT @DESC_ERROR = 'El Rol ingresado no existe.';
		RETURN;
	END	

	SELECT @CANTIDAD = COUNT(*) FROM FLOPANICMA.ROL_FUNCIONALIDAD RF, FLOPANICMA.ROL R
	WHERE R.ID_ROL = RF.ID_ROL
	AND R.DESCRIPCION = @DESCRIPCION;

	IF (@CANTIDAD IS NULL OR @CANTIDAD = 0)
	BEGIN
		SELECT @ID_ERROR = 1;
		SELECT @DESC_ERROR = 'El Rol seleccionado no tiene Funcionalidades asociadas.';
		RETURN;
	END	

	SELECT F.ID_FUNCIONALIDAD, F.DESCRIPCION 
	FROM FLOPANICMA.FUNCIONALIDAD F, FLOPANICMA.ROL_FUNCIONALIDAD RF, FLOPANICMA.ROL R
	WHERE R.ID_ROL = RF.ID_ROL
	AND RF.ID_FUNCIONALIDAD = F.ID_FUNCIONALIDAD
	AND R.DESCRIPCION = @DESCRIPCION;
END;
GO

/*MODIFICAR PLAN de un AFILIADO*/

CREATE PROCEDURE FLOPANICMA.SP_MODIFICACION_PLAN_AFILIADO 
@USERNAME_ID INT,
@PLAN_MEDICO_ANTERIOR NUMERIC(18,0),
@PLAN_MEDICO_NUEVO NUMERIC(18,0),
@DETALLE VARCHAR(255),

@ID_ERROR INT OUTPUT,
@DESC_ERROR VARCHAR(255) OUTPUT

AS
BEGIN
	DECLARE @FECHA_ACTUAL DATE;

	SELECT @DESC_ERROR = '';
	SELECT @FECHA_ACTUAL = GETDATE();


	IF (@PLAN_MEDICO_NUEVO IS NULL)
	BEGIN
		SELECT @ID_ERROR = 1;
		SELECT @DESC_ERROR = 'No se ingresó un nuevo plan médico';
		RETURN;
	END	
	ELSE
	BEGIN
		/* Actualizamos tabla de AFILIADO con el NUEVO PLAN */
		UPDATE FLOPANICMA.AFILIADO
		SET PLAN_MEDICO=@PLAN_MEDICO_NUEVO
		WHERE ID_AFILIADO=@USERNAME_ID;
		
		/* Insertamos nuevo registro ebb MODIFICACION de PLAN de AFILIADO 
		INSERT INTO FLOPANICMA.MODIFICACION
		VALUES (@USERNAME_ID, @FECHA_ACTUAL, @DETALLE, @PLAN_MEDICO_ANTERIOR);
		*/
		RETURN;
	END

END;
GO

  /*BAJA de un AFILIADO*/

CREATE PROCEDURE FLOPANICMA.SP_BAJA_AFILIADO 
@USERNAME_ID INT,
@ACTIVO_ANTERIOR BIT,
@ACTIVO_NUEVO BIT,

@ID_ERROR INT OUTPUT,
@DESC_ERROR VARCHAR(255) OUTPUT

AS
BEGIN
	DECLARE @FECHA_ACTUAL DATE;

	SELECT @DESC_ERROR = '';
	SELECT @FECHA_ACTUAL = GETDATE();

	IF (@ACTIVO_NUEVO IS NULL)
	BEGIN
		SELECT @ID_ERROR = 1;
		SELECT @DESC_ERROR = 'No se ingresó estado para el afiliado';
		RETURN;
	END	
	ELSE
	BEGIN
		IF (@ACTIVO_ANTERIOR = 1)
		BEGIN
		/* Actualizamos tabla de AFILIADO el ACTIVO en false */
		UPDATE FLOPANICMA.AFILIADO
		SET ACTIVO=@ACTIVO_NUEVO
		WHERE ID_AFILIADO=@USERNAME_ID;
		RETURN;
		END
	END

END;
GO
 
CREATE PROCEDURE FLOPANICMA.SP_ABM_ROL_ALTA
@DESC_ROL VARCHAR(255),
@FLAG_ERROR BIT = 0 OUTPUT,
@MENSAJE VARCHAR(255) = '' OUTPUT
AS
BEGIN
	--VALIDACIONES--
	IF(@DESC_ROL IS NULL) OR (@DESC_ROL = '') -- valida el ingreso de un nombre obligatorio
	BEGIN
		SET @FLAG_ERROR = 1;
		SET @MENSAJE = 'Debe ingresar un nombre para el rol a crear';
		RETURN
	END
	
	--PROCEDIMIENTO--
	IF((SELECT COUNT(1) FROM FLOPANICMA.ROL AS ROL WHERE ROL.DESCRIPCION = FLOPANICMA.TRIM(UPPER(@DESC_ROL))) > 0) -- valida que el rol no se encuentre cargado en la base
	BEGIN
		SET @FLAG_ERROR = 1;
		SET @MENSAJE = 'El rol ingresado ya existe';
		RETURN
	END 
	ELSE
	BEGIN
		INSERT INTO FLOPANICMA.ROL (DESCRIPCION, ACTIVO) VALUES (@DESC_ROL,1);
		SET @MENSAJE = 'El rol "' + @DESC_ROL + '" se ha guardado correctamente';
	END
END
GO

CREATE PROCEDURE FLOPANICMA.GET_ROLES_POR_DESCRIPCION(@DESCRIPCION_ROL VARCHAR(50))
AS
BEGIN
	IF(@DESCRIPCION_ROL IS NULL)
	BEGIN
		SET @DESCRIPCION_ROL = '';
	END
	
	SET @DESCRIPCION_ROL = FLOPANICMA.TRIM(@DESCRIPCION_ROL);

	SELECT R.ID_ROL, R.DESCRIPCION, R.ACTIVO
	FROM FLOPANICMA.ROL R
	WHERE R.DESCRIPCION LIKE '%'+@DESCRIPCION_ROL+'%';
END
GO

/* GET_ALL_FUNCIONALIDADES */

CREATE PROCEDURE FLOPANICMA.GET_ALL_FUNCIONALIDADES 
AS
BEGIN
	SELECT F.ID_FUNCIONALIDAD, F.DESCRIPCION 
	FROM FLOPANICMA.FUNCIONALIDAD F;
END
GO


/* PERMITE AGREGAR UNA FUNCIONALIDAD DEFINIDA A UN ROL EXISTENTE. 
  (Llamamos a este procedimiento desde la seccion de "modificacion" de la aplicacion.
   Crea un nuevo registro en la tabla asociativa FLOPANICMA.ROL_FUNCIONALIDAD) */

CREATE PROCEDURE FLOPANICMA.SP_ABM_ROL_AGREGAR_FUNCIONALIDAD
@DESC_ROL VARCHAR(255),
@DESC_FUNCIONALIDAD VARCHAR(255),
@FLAG_ERROR BIT OUTPUT,
@MENSAJE VARCHAR(255) OUTPUT
AS
BEGIN
	--DECLARACIONES--
	DECLARE @ID_ROL INT;
	DECLARE @ID_FUNCIONALIDAD INT;
	
	--VALIDACIONES--
	SELECT @ID_ROL = ROL.ID_ROL -- busca el rol por su descripcion en la base
	FROM FLOPANICMA.ROL AS ROL 
	WHERE ROL.DESCRIPCION = FLOPANICMA.TRIM(UPPER(@DESC_ROL));
	
	IF(@ID_ROL IS NULL) -- en caso de que se este queriendo agregar una funcionalidad a un rol inexistente corta la ejecucion y devuelve un mensaje de error 
	BEGIN
		SET @FLAG_ERROR = 1;
		SET @MENSAJE = 'El rol especificado no existe';
		RETURN
	END
	
	SELECT @ID_FUNCIONALIDAD = FUNCIONALIDAD.ID_FUNCIONALIDAD -- idem para funcionalidad
	FROM FLOPANICMA.FUNCIONALIDAD AS FUNCIONALIDAD
	WHERE FUNCIONALIDAD.DESCRIPCION = FLOPANICMA.TRIM(UPPER(@DESC_FUNCIONALIDAD));
	
	IF(@ID_FUNCIONALIDAD IS NULL) OR (@DESC_FUNCIONALIDAD = '')
	BEGIN
		SET @FLAG_ERROR = 1;
		SET @MENSAJE = 'La funcionalidad especificada no existe';
		RETURN
	END

	--PROCEDIMIENTO--
	IF EXISTS(SELECT  1 
				  FROM FLOPANICMA.ROL_FUNCIONALIDAD AS ROL_FUNCIONALIDAD 
				  WHERE (ROL_FUNCIONALIDAD.ID_ROL = @ID_ROL) AND (ROL_FUNCIONALIDAD.ID_FUNCIONALIDAD = @ID_FUNCIONALIDAD)) -- valida que la nueva funcionalidad no haya sido anteriormente asignada al rol
	BEGIN
		SET @FLAG_ERROR = 1;
		SET @MENSAJE = 'La funcionalidad "' + @DESC_FUNCIONALIDAD + '" ya ha sido anteriormente asignada al rol "' + @DESC_ROL + '".';
		RETURN
	END
	ELSE
	BEGIN
		INSERT INTO FLOPANICMA.ROL_FUNCIONALIDAD (ID_ROL,ID_FUNCIONALIDAD) VALUES (@ID_ROL,@ID_FUNCIONALIDAD);
		SET @FLAG_ERROR = 0;
		SET @MENSAJE = 'La funcionalidad "' + @DESC_FUNCIONALIDAD + '" ha sido asignada correctamente al rol "' + @DESC_ROL + '".';
	END
END
GO


/* PERMITE QUITAR UNA FUNCIONALIDAD DEFINIDA A UN ROL EXISTENTE. 
  (Llamamos a este procedimiento desde la seccion de "modificacion" de la aplicacion.
   Elimina un registro de la tabla asociativa FLOPANICMA.ROL_FUNCIONALIDAD) */
 
CREATE PROCEDURE FLOPANICMA.SP_ABM_ROL_QUITAR_FUNCIONALIDAD
@DESC_ROL VARCHAR(255),
@DESC_FUNCIONALIDAD VARCHAR(255),
@FLAG_ERROR BIT OUTPUT,
@MENSAJE VARCHAR(255) OUTPUT
AS
BEGIN
	--DECLARACIONES--
	DECLARE @ID_ROL INT;
	DECLARE @ID_FUNCIONALIDAD VARCHAR(255);
	
	--VALIDACIONES--
	SELECT @ID_ROL = ID_ROL
	FROM FLOPANICMA.ROL AS ROL
	WHERE ROL.DESCRIPCION = FLOPANICMA.TRIM(UPPER(@DESC_ROL));
	
	IF(@ID_ROL IS NULL) -- valida que exista el rol al que le quiero quitar la funcionalidad
	BEGIN
		SET @FLAG_ERROR = 1;
		SET @MENSAJE = 'El rol especificado no existe';
		RETURN
	END
	
	SELECT @ID_FUNCIONALIDAD = ID_FUNCIONALIDAD
	FROM FLOPANICMA.FUNCIONALIDAD AS FUNCIONALIDAD
	WHERE FUNCIONALIDAD.DESCRIPCION = FLOPANICMA.TRIM(UPPER(@DESC_FUNCIONALIDAD));
	
	IF(@ID_FUNCIONALIDAD IS NULL) -- idem para funcionalidad
	BEGIN
		SET @FLAG_ERROR = 1;
		SET @MENSAJE = 'La funcionalidad especificada no existe';
		RETURN
	END
	
	--PROCEDIMIENTO--
	IF EXISTS(SELECT 1 
			  FROM FLOPANICMA.ROL_FUNCIONALIDAD AS ROL_FUNCIONALIDAD 
			  WHERE (ROL_FUNCIONALIDAD.ID_ROL = @ID_ROL) AND (ROL_FUNCIONALIDAD.ID_FUNCIONALIDAD = @ID_FUNCIONALIDAD))
	BEGIN		  
		DELETE FROM FLOPANICMA.ROL_FUNCIONALIDAD WHERE (ID_ROL = @ID_ROL) AND (ID_FUNCIONALIDAD = @ID_FUNCIONALIDAD);
		SET @FLAG_ERROR = 0;
		SET @MENSAJE = 'La funcionalidad se ha quitado exitosamente.';
	END
	ELSE
	BEGIN
		SET @FLAG_ERROR = 1;
		SET @MENSAJE = 'La funcionalidad que desea quitar no se encuentra asignada al rol especificado.'
	END	
END
GO



/* PERMITE MODIFICAR EL NOMBRE O EL ESTADO DE UN ROL EXISTENTE
   (puedo cambiar el nombre y volver a habilitar el estado de rol) */
   
CREATE PROCEDURE FLOPANICMA.SP_ABM_ROL_MODIFICAR_NOMBRE
@ID_ROL INT,
@DESC_ROL VARCHAR(255),
@FLAG_ERROR BIT = 0 OUTPUT,
@MENSAJE VARCHAR(255) = '' OUTPUT
AS
BEGIN
	--DECLARACIONES--
	DECLARE @CANT_REGISTROS INT;
	
	--VALIDACIONES--
	SELECT @CANT_REGISTROS = COUNT(1) FROM
	FLOPANICMA.ROL AS ROL 
	WHERE ROL.ID_ROL = @ID_ROL;

	IF(@ID_ROL IS NULL) OR (@CANT_REGISTROS = 0)
	BEGIN
		SET @FLAG_ERROR = 1;
		SET @MENSAJE = 'El rol que desea modificar no existe.';
		RETURN
	END
	
	IF (@DESC_ROL IS NULL) OR (@DESC_ROL = '') -- evito que guarde en la base una descripcion "null" o una palabra vacia
	BEGIN
		SET @FLAG_ERROR = 1;
		SET @MENSAJE = 'Debe ingresar un nombre para modificar.';
		RETURN
	END
	
	--PROCEDIMIENTO--
	UPDATE FLOPANICMA.ROL -- modifico el nombre del rol
	SET DESCRIPCION = FLOPANICMA.TRIM(UPPER(@DESC_ROL))
	WHERE ID_ROL = @ID_ROL;
	
	SET @MENSAJE = ('El rol "' + @DESC_ROL + '" se ha guardado correctamente.');
END
GO

CREATE PROCEDURE FLOPANICMA.SP_ABM_ROL_ACTIVAR_DESACTIVAR
@ID_ROL INT,
@ACTIVO BIT,
@FLAG_ERROR BIT = 0 OUTPUT,
@MENSAJE VARCHAR(255) = '' OUTPUT
AS
BEGIN
	--DECLARACIONES--
	DECLARE @CANT_REGISTROS INT;
	
	--VALIDACIONES--
	SELECT @CANT_REGISTROS = COUNT(1) FROM
	FLOPANICMA.ROL AS ROL 
	WHERE ROL.ID_ROL = @ID_ROL;
	
	IF(@ID_ROL IS NULL) OR (@CANT_REGISTROS = 0)
	BEGIN
		SET @FLAG_ERROR = 1;
		SET @MENSAJE = 'El rol que desea eliminar no existe.';
		RETURN
	END
	
	--PROCEDIMIENTO--
	IF(@ACTIVO = 1)
		UPDATE FLOPANICMA.ROL 
		SET ACTIVO = 0 
		WHERE ID_ROL = @ID_ROL;
	ELSE
		UPDATE FLOPANICMA.ROL
		SET ACTIVO = 1
		WHERE ID_ROL = @ID_ROL;
END
GO


/*PERMITE REGISTRAR LA COMPRA DE N BONOS
(Se utiliza este procedimiento desde el menu compra bono, que esta habilitado para los usuarios del 
rol afiliado y administrativo, recordar que el afiliado puede comprar los bonos en el mostrador y le 
corresponde al administrativo registrar dicha compra.*/
CREATE PROCEDURE FLOPANICMA.SP_COMPRA_BONOS
@CANTIDAD INT,
@ID_AFILIADO INT,
@IMPORTE NUMERIC(10,2) OUTPUT

AS

BEGIN

DECLARE @FECHA DATETIME;

SET @FECHA = GETDATE(); --PARA NO COMPLICAR LA VIDA LA FECHA DE COMPRA Y DE IMPRESION ES LA MISMA. ESPECIFICAR EN LA ESTRATEGIA

INSERT INTO FLOPANICMA.COMPRA_BONO
(ID_AFILIADO,CANTIDAD_BONOS,FECHA_COMPRA,FECHA_IMPRESION)
VALUES (@ID_AFILIADO,@CANTIDAD,@FECHA,@FECHA);
--CALCULAR IMPORTE TOTAL DE LOS BONOS COMPRADOS

END;

GO
