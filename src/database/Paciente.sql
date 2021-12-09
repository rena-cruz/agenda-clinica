CREATE TABLE Paciente(
    SeqPaciente NUMBER(15),
    Nome VARCHAR2(50) NOT NULL,
    DtaNascimento DATE NOT NULL,
    Telefone NUMBER(11) NOT NULL,
    Email VARCHAR2(50),
    SeqFinanceiro NUMBER(15)
);
ALTER TABLE Paciente ADD CONSTRAINT PacientePK PRIMARY KEY(SeqPaciente);

ALTER TABLE Paciente ADD CONSTRAINT PacienteFK FOREIGN KEY(SeqFinanceiro) REFERENCES SituacaoFinanceira(SeqFinanceiro);

COMMENT ON TABLE Paciente IS 'Tabela que tem os cadastros de paciente';
COMMENT ON COLUMN Paciente.SeqPaciente IS 'S_Paciente';

CREATE SEQUENCE S_Paciente;