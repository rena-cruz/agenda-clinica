CREATE TABLE SituacaoFinanceira(
    SeqFinanceiro NUMBER(15),
    IndFinanceiro VARCHAR2(30) NOT NULL 
);
ALTER TABLE SituacaoFinanceira ADD CONSTRAINT SituacaoFinanceiraPK PRIMARY KEY(SeqFinanceiro);

COMMENT ON TABLE SituacaoFinanceira IS 'Tabela que tem as situacoes financeiras que podem ser vinculadas aos pacientes';
COMMENT ON COLUMN SituacaoFinanceira.SeqFinanceiro IS 'S_SituacaoFinanceira';
COMMENT ON COLUMN SituacaoFinanceira.IndFinanceiro IS 'Opcoes: Bloqueado, Liberado, Restricao';

CREATE SEQUENCE S_SituacaoFinanceira;

INSERT INTO SituacaoFinanceira(SeqFinanceiro, IndFinanceiro) VALUES (S_SituacaoFinanceira.nextval, 'Bloqueado');
INSERT INTO SituacaoFinanceira(SeqFinanceiro, IndFinanceiro) VALUES (S_SituacaoFinanceira.nextval, 'Liberado');
INSERT INTO SituacaoFinanceira(SeqFinanceiro, IndFinanceiro) VALUES (S_SituacaoFinanceira.nextval, 'Restricao');