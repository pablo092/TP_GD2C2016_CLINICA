USE GD2C2016;
GO

DROP SEQUENCE FLOPANICMA.AFILIADO_SEQ;
DROP SEQUENCE FLOPANICMA.MATRICULA_SEQ;
DROP SEQUENCE FLOPANICMA.PERSONA_SEQ;
DROP SEQUENCE FLOPANICMA.ID_TURNO_SEQ;
DROP PROCEDURE FLOPANICMA.GET_ROLES_POR_DESCRIPCION;
DROP PROCEDURE FLOPANICMA.GET_ROLES_POR_USUARIO;
DROP PROCEDURE FLOPANICMA.GET_FUNCIONALIDADES_POR_ROL;
DROP PROCEDURE FLOPANICMA.GET_FECHAS_DISPONIBLES_AGENDA_PROFESIONAL;
DROP PROCEDURE FLOPANICMA.GET_PROFESIONALES_POR_ESPECIALIDAD;
DROP PROCEDURE FLOPANICMA.GET_ALL_FUNCIONALIDADES;
DROP PROCEDURE FLOPANICMA.LOGIN_USUARIO;
DROP PROCEDURE FLOPANICMA.SP_AFILIADO_BAJA;
DROP PROCEDURE FLOPANICMA.SP_AFILIADO_MODIFICACION;
DROP PROCEDURE FLOPANICMA.SP_ABM_ROL_ACTIVAR_DESACTIVAR;
DROP PROCEDURE FLOPANICMA.SP_ABM_ROL_MODIFICAR_NOMBRE;
DROP PROCEDURE FLOPANICMA.SP_ABM_ROL_AGREGAR_FUNCIONALIDAD;
DROP PROCEDURE FLOPANICMA.SP_ABM_ROL_ALTA;
DROP PROCEDURE FLOPANICMA.SP_ABM_ROL_QUITAR_FUNCIONALIDAD;
DROP PROCEDURE FLOPANICMA.SP_COMPRA_BONOS;
DROP PROCEDURE FLOPANICMA.SP_MIGRACION_CONSULTAS_BONOS;
DROP PROCEDURE FLOPANICMA.SP_MIGRACION_AFILIADOS;
DROP PROCEDURE FLOPANICMA.SP_MIGRACION_PROFESIONALES;
DROP PROCEDURE FLOPANICMA.SP_MIGRACION_INSERT_DATOS_FIJOS;
DROP PROCEDURE FLOPANICMA.SP_MIGRACION_ESPECIALIDADES;
DROP PROCEDURE FLOPANICMA.SP_MIGRACION_AGENDA;
DROP PROCEDURE FLOPANICMA.SP_REGISTRAR_AGENDA;
DROP PROCEDURE FLOPANICMA.SP_REGISTRAR_PEDIDO_TURNO;
DROP PROCEDURE FLOPANICMA.SP_CANCELACION_TURNO_AFILIADO;
DROP PROCEDURE FLOPANICMA.SP_CANCELACION_TURNO_PROFESIONAL;
DROP PROCEDURE FLOPANICMA.SP_FAMILIARES;
DROP PROCEDURE FLOPANICMA.SP_GET_AFILIADO_PARA_MODIF;
DROP PROCEDURE FLOPANICMA.SP_HISTORIAL_MODIF_PLAN;
DROP PROCEDURE FLOPANICMA.SP_LEST_ESP_MAS_CANCELADAS;
DROP PROCEDURE FLOPANICMA.SP_LEST_PROF_MAS_CONSULTADOS_POR_PLAN;
DROP PROCEDURE FLOPANICMA.SP_LEST_PROF_MENOS_HS_TRABAJADAS;
DROP PROCEDURE FLOPANICMA.SP_LEST_AFILIADO_MAS_BONOS_COMPRADOS;
DROP PROCEDURE FLOPANICMA.SP_LEST_ESPECIALIDAD_MAS_BONOS_USADOS;
DROP PROCEDURE FLOPANICMA.SP_REGISTRAR_LLEGADA_ATENCION_MEDICA;
DROP PROCEDURE FLOPANICMA.SP_REGISTRO_RESULTADO_ATENCION_MEDICA;
DROP PROCEDURE FLOPANICMA.SP_ALTA_AFILIADO_RAIZ;
DROP PROCEDURE FLOPANICMA.SP_ALTA_AFILIADO_ASOCIADO;
DROP PROCEDURE FLOPANICMA.SP_MODIFICAR_AFILIADO;
DROP PROCEDURE FLOPANICMA.SP_VINCULAR_AFILIADOS;
DROP FUNCTION FLOPANICMA.TRIM;
DROP FUNCTION FLOPANICMA.PASSWORD_HASH;
DROP FUNCTION FLOPANICMA.TURNOS_HORA;
DROP FUNCTION FLOPANICMA.HORARIO_ASIGNADO;
DROP FUNCTION FLOPANICMA.LIMITE_HORAS_SEMANALES;
DROP FUNCTION FLOPANICMA.PERTENECE_A_GRUPO;
DROP FUNCTION FLOPANICMA.SON_FAMILIARES;
DROP FUNCTION FLOPANICMA.TURNO_OCUPADO
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
DROP TABLE FLOPANICMA.AGENDA;
DROP TABLE FLOPANICMA.ESPECIALIDAD;
DROP TABLE FLOPANICMA.TIPO_ESPECIALIDAD;
DROP TABLE FLOPANICMA.PROFESIONAL;
DROP TABLE FLOPANICMA.PERSONA;
DROP SCHEMA FLOPANICMA;


GO