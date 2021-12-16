CREATE TABLE Usuario(
    SeqUsuario NUMBER(15),
    Login VARCHAR2(30),
    Senha VARCHAR2(20)
);
ALTER TABLE Usuario ADD CONSTRAINT UsuarioPK PRIMARY KEY(SeqUsuario);

COMMENT ON TABLE Usuario IS 'Tabela que salva as senhas e usuarios para acesso a aplicacao';
COMMENT ON COLUMN Usuario.SeqUsuario IS 'S_Usuario';

CREATE SEQUENCE S_Usuario;

INSERT INTO Usuario(SeqUsuario, Login, Senha) VALUES(S_Usuario.NEXTVAL, 'Admin', '123');

COMMIT;

