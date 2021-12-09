CREATE TABLE Agendamento(
    SeqAgendamento NUMBER(15),
    DtaHorAgendamento DATE NOT NULL,
    VlrAgendamento NUMBER(7,2) NOT NULL,
    CRM VARCHAR2(10),
    SeqPaciente NUMBER(15),
    SeqFormaPagto NUMBER(15)
);
ALTER TABLE Agendamento ADD CONSTRAINT AgendamentoPK PRIMARY KEY(SeqAgendamento);

ALTER TABLE Agendamento ADD CONSTRAINT AgendamentoFK FOREIGN KEY(SeqPaciente) REFERENCES Paciente(SeqPaciente);
ALTER TABLE Agendamento ADD CONSTRAINT AgendamentoFK2 FOREIGN KEY(SeqFormaPagto) REFERENCES FormaPagto(SeqFormaPagto);
ALTER TABLE Agendamento ADD CONSTRAINT AgendamentoFK3 FOREIGN KEY(CRM) REFERENCES Medico(CRM);

COMMENT ON TABLE Agendamento IS 'Tabela que tem a lista dos agendamentos marcados';
COMMENT ON COLUMN Agendamento.SeqAgendamento IS 'S_Agendamento';

CREATE SEQUENCE S_Agendamento; 