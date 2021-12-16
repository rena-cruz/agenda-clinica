CREATE TABLE Periodo(
    SeqPeriodo NUMBER(15),
    Periodo VARCHAR2(30) NOT NULL
);
ALTER TABLE Periodo ADD CONSTRAINT PeriodoPK PRIMARY KEY(SeqPeriodo);

COMMENT ON TABLE Periodo IS 'Tabela que tem os periodos para agendamento';
COMMENT ON COLUMN Periodo.SeqPeriodo IS 'S_Periodo';

CREATE SEQUENCE S_Periodo;

INSERT INTO Periodo(SeqPeriodo, Periodo) VALUES (S_Periodo.nextval, 'Manha');
INSERT INTO Periodo(SeqPeriodo, Periodo) VALUES (S_Periodo.nextval, 'Tarde');
INSERT INTO Periodo(SeqPeriodo, Periodo) VALUES (S_Periodo.nextval, 'Noite');

COMMIT;

