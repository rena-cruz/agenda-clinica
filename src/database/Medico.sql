CREATE TABLE Medico(
    CRM VARCHAR2(10),
    Nome VARCHAR2(50) NOT NULL,
    Email VARCHAR2(50),
    SeqEspecialidade NUMBER(15)
);
ALTER TABLE Medico ADD CONSTRAINT MedicoPK PRIMARY KEY(CRM);

ALTER TABLE Medico ADD CONSTRAINT MedicoFK FOREIGN KEY(SeqEspecialidade) REFERENCES EspecialidadeMedico(SeqEspecialidade);

COMMENT ON TABLE Medico IS 'Tabela que tem os cadastros de medico';
