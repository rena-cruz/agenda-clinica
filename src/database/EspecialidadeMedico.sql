CREATE TABLE EspecialidadeMedico(
    SeqEspecialidade NUMBER(15),
    Especialidade VARCHAR2(30) NOT NULL,
    VlrPadraoConsulta NUMBER(5,2)NOT NULL 
);
ALTER TABLE EspecialidadeMedico ADD CONSTRAINT EspecialidadeMedicoPK PRIMARY KEY(SeqEspecialidade);

COMMENT ON TABLE EspecialidadeMedico IS 'Tabela que tem as especialidade dos medicos';
COMMENT ON COLUMN EspecialidadeMedico.SeqEspecialidade IS 'S_EspecialidadeMedico';
COMMENT ON COLUMN EspecialidadeMedico.VlrPadraoConsulta IS 'Tabela que tem o valor padrao da consulta';

CREATE SEQUENCE S_EspecialidadeMedico;

INSERT INTO EspecialidadeMedico(SeqEspecialidade, Especialidade, VlrPadraoConsulta) VALUES (S_EspecialidadeMedico.nextval, 'Cardiologia', '190,00');
INSERT INTO EspecialidadeMedico(SeqEspecialidade, Especialidade, VlrPadraoConsulta) VALUES (S_EspecialidadeMedico.nextval, 'Geriatria', '100,00');
INSERT INTO EspecialidadeMedico(SeqEspecialidade, Especialidade, VlrPadraoConsulta) VALUES (S_EspecialidadeMedico.nextval, 'Ginecologia', '90,00');
INSERT INTO EspecialidadeMedico(SeqEspecialidade, Especialidade, VlrPadraoConsulta) VALUES (S_EspecialidadeMedico.nextval, 'Oncologia', '380,00');
INSERT INTO EspecialidadeMedico(SeqEspecialidade, Especialidade, VlrPadraoConsulta) VALUES (S_EspecialidadeMedico.nextval, 'Pediatria', '80,00');
INSERT INTO EspecialidadeMedico(SeqEspecialidade, Especialidade, VlrPadraoConsulta) VALUES (S_EspecialidadeMedico.nextval, 'Urologia', '160,00');

COMMIT;
 