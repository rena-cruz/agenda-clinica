CREATE TABLE Jornada(
    SeqJornada NUMBER(15),
    SeqDiaSemana NUMBER(15),
    SeqPeriodo NUMBER(15)
);
ALTER TABLE Jornada ADD CONSTRAINT JornadaPK PRIMARY KEY(SeqJornadaMedico);

ALTER TABLE Jornada ADD CONSTRAINT JornadaFK FOREIGN KEY(SeqDiaSemana) REFERENCES DiaSemana(SeqDiaSemana);
ALTER TABLE Jornada ADD CONSTRAINT JornadaFK2 FOREIGN KEY(SeqPeriodo) REFERENCES Periodo(SeqPeriodo);

COMMENT ON TABLE Jornada IS 'Tabela que tem a jornada para agendamento';
COMMENT ON COLUMN Jornada.SeqJornada IS 'S_Jornada';

CREATE SEQUENCE S_Jornada;

