CREATE TABLE FormaPagto(
    SeqFormaPagto NUMBER(15),
    FormaPagto VARCHAR2(50) NOT NULL
);
ALTER TABLE FormaPagto ADD CONSTRAINT FormaPagtoPK PRIMARY KEY(SeqFormaPagto);

COMMENT ON TABLE FormaPagto IS 'Tabela que tem as formas de pagamento usadas no agendamento de consulta';
COMMENT ON COLUMN FormaPagto.SeqFormaPagto IS 'S_FormaPagto';
COMMENT ON COLUMN FormaPagto.FormaPagto IS 'Opcoes: Boleto, Dinheiro, Cartao';

CREATE SEQUENCE S_FormaPagto;

INSERT INTO Formapagto(Seqformapagto, Formapagto) VALUES (S_Formapagto.nextval, 'Boleto');
INSERT INTO Formapagto(Seqformapagto, Formapagto) VALUES (S_Formapagto.nextval, 'Cartao');
INSERT INTO Formapagto(Seqformapagto, Formapagto) VALUES (S_Formapagto.nextval, 'Dinheiro');

COMMIT;