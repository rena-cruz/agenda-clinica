CREATE TABLE DiaSemana(
    SeqDiaSemana NUMBER(15),
    DiaSemana VARCHAR2(30) NOT NULL
);
ALTER TABLE DiaSemana ADD CONSTRAINT DiaSemanaPK PRIMARY KEY(SeqDiaSemana);

COMMENT ON TABLE DiaSemana IS 'Tabela com os dias da semana';
COMMENT ON COLUMN DiaSemana.SeqDiaSemana IS 'S_DiaSemana';

CREATE SEQUENCE S_DiaSemana;

INSERT INTO DiaSemana(SeqDiaSemana, DiaSemana) VALUES (S_DiaSemana.nextval, 'Segunda');
INSERT INTO DiaSemana(SeqDiaSemana, DiaSemana) VALUES (S_DiaSemana.nextval, 'Terca');
INSERT INTO DiaSemana(SeqDiaSemana, DiaSemana) VALUES (S_DiaSemana.nextval, 'Quarta');
INSERT INTO DiaSemana(SeqDiaSemana, DiaSemana) VALUES (S_DiaSemana.nextval, 'Quinta');
INSERT INTO DiaSemana(SeqDiaSemana, DiaSemana) VALUES (S_DiaSemana.nextval, 'Sexta');
INSERT INTO DiaSemana(SeqDiaSemana, DiaSemana) VALUES (S_DiaSemana.nextval, 'Sabado');
INSERT INTO DiaSemana(SeqDiaSemana, DiaSemana) VALUES (S_DiaSemana.nextval, 'Domingo');

COMMIT;

