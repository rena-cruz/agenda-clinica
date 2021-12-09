CREATE TABLE JornadaMedico(
    SeqJornadaMedico NUMBER(15),
    CRM VARCHAR2(10),
    SeqJornada NUMBER(15)
);
ALTER TABLE JornadaMedico ADD CONSTRAINT JornadaMedicoPK PRIMARY KEY(SeqJornadaMedico);

ALTER TABLE JornadaMedico ADD CONSTRAINT JornadaMedicoFK FOREIGN KEY(CRM) REFERENCES Medico(CRM);
ALTER TABLE JornadaMedico ADD CONSTRAINT JornadaMedicoFK2 FOREIGN KEY(SeqJornada) REFERENCES Jornada(SeqJornada);

COMMENT ON TABLE JornadaMedico IS 'Tabela que tem a jornada do medico';
COMMENT ON COLUMN JornadaMedico.SeqJornadaMedico IS 'S_JornadaMedico';

CREATE SEQUENCE S_JornadaMedico;

