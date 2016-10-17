USE GD2C2016;
GO

DROP SEQUENCE FLOPANICMA.AFILIADO_SEQ;
DROP SEQUENCE FLOPANICMA.MATRICULA_SEQ;
DROP SEQUENCE FLOPANICMA.PERSONA_SEQ;
DROP PROCEDURE FLOPANICMA.GET_ROLES_POR_USUARIO;
DROP PROCEDURE FLOPANICMA.GET_FUNCIONALIDADES_POR_ROL; 
DROP PROCEDURE FLOPANICMA.LOGIN_USUARIO;
DROP PROCEDURE FLOPANICMA.Z_MIGRACION_CONSULTAS_BONOS;
DROP PROCEDURE FLOPANICMA.Z_MIGRACION_AFILIADOS;
DROP PROCEDURE FLOPANICMA.Z_MIGRACION_PROFESIONALES;
DROP PROCEDURE FLOPANICMA.Z_MIGRACION_INSERT_DATOS_FIJOS;
DROP PROCEDURE FLOPANICMA.Z_MIGRACION_ESPECIALIDADES;
DROP PROCEDURE FLOPANICMA.MODIFICACION_PLAN_AFILIADO;
DROP FUNCTION FLOPANICMA.TRIM;
DROP FUNCTION FLOPANICMA.PASSWORD_HASH;
DROP TABLE FLOPANICMA.ROL_FUNCIONALIDAD;
DROP TABLE FLOPANICMA. USUARIO_ROL;
DROP TABLE FLOPANICMA.USUARIO;
DROP TABLE FLOPANICMA.ROL;
DROP TABLE FLOPANICMA.FUNCIONALIDAD;
DROP TABLE FLOPANICMA.CONSULTA;
DROP TABLE FLOPANICMA.CANCELACION;
DROP TABLE FLOPANICMA.TIPO_CANCELACION;
DROP TABLE FLOPANICMA.PEDIDO_TURNO;
DROP TABLE FLOPANICMA.ESPECIALIDAD_PROFESIONAL;
DROP TABLE FLOPANICMA.MODIFICACION;
DROP TABLE FLOPANICMA.BONO;
DROP TABLE FLOPANICMA.COMPRA_BONO;
DROP TABLE FLOPANICMA.AFILIADO;
DROP TABLE FLOPANICMA.PLAN_MEDICO;
DROP TABLE FLOPANICMA.ACTIVIDAD_DIA;
DROP TABLE FLOPANICMA.ESPECIALIDAD;
DROP TABLE FLOPANICMA.TIPO_ESPECIALIDAD;
DROP TABLE FLOPANICMA.AGENDA;
DROP TABLE FLOPANICMA.PROFESIONAL;
DROP TABLE FLOPANICMA.PERSONA;
DROP SCHEMA FLOPANICMA;


GO
