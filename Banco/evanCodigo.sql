CREATE DATABASE evanew;
USE evanew;
-- DROP DATABASE EVANEW;


CREATE TABLE pes_pessoa(
	pes_id INT PRIMARY KEY AUTO_INCREMENT,
    pes_nome VARCHAR(50) NOT NULL,
    pes_sexo VARCHAR(1) NOT NULL,
    pes_nascimento DATE NOT NULL,
    pes_cidade VARCHAR(20),
    pes_estado VARCHAR(2)
);

CREATE TABLE usu_usuario(
  usu_id INT(11) PRIMARY KEY NOT NULL AUTO_INCREMENT,
  usu_email VARCHAR(100) NOT NULL,
  usu_senha VARCHAR(100) NOT NULL,
  usu_status BOOL DEFAULT TRUE,
  usu_tipo ENUM('Passageiro', 'Motorista', 'Administrador') NOT NULL,
  pes_id INT,
  unique key (usu_email),
  FOREIGN KEY (pes_id) REFERENCES pes_pessoa(pes_id)
);

/*CREATE TABLE adm_administrador (
  adm_id INT(11) PRIMARY KEY NOT NULL AUTO_INCREMENT,
  adm_nome VARCHAR(40) NOT NULL,
  adm_sexo VARCHAR(1) NOT NULL,
  adm_nascimento DATE NOT NULL,
  adm_estado CHAR(2) NOT NULL,
  adm_cidade VARCHAR(20) NOT NULL,
  usu_id int,
  foreign key (usu_id) references usu_usuario(usu_id));
*/


CREATE TABLE pas_passageiro (
  pas_id INT(11) PRIMARY KEY NOT NULL AUTO_INCREMENT,
  pas_cpf VARCHAR(15) NOT NULL,
  usu_id int,
  foreign key (usu_id) references usu_usuario(usu_id));
  


CREATE TABLE mot_motorista (
  mot_id INT(11) PRIMARY KEY NOT NULL AUTO_INCREMENT,
  mot_cnpj VARCHAR(18) NOT NULL,
  usu_id int,
  foreign key (usu_id) references usu_usuario(usu_id));


CREATE TABLE tdo_tipodocumento (
  tdo_id INT(11) PRIMARY KEY NOT NULL AUTO_INCREMENT,
  tdo_image VARCHAR(255) NOT NULL
  -- tdo_obrigatorio TINYINT NOT NULL DEFAULT '0'
);


CREATE TABLE doc_documento (
  mot_id INT(11) NOT NULL,
  FOREIGN KEY (mot_id) references mot_motorista(mot_id),
  tdo_id INT(11) NOT NULL,
  FOREIGN KEY (tdo_id) references tdo_tipodocumento(tdo_id)
  );
  
CREATE  TABLE con_condutor (
	con_id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
    con_nome VARCHAR(20) NOT NULL,
    con_cpf VARCHAR(13) NOT NULL,
    mot_id INT NOT NULL,
    FOREIGN KEY (mot_id) REFERENCES mot_motorista(mot_id)
);

CREATE TABLE ser_servicos (
  ser_id INT(11) PRIMARY KEY NOT NULL AUTO_INCREMENT,
  ser_datacadastro DATETIME NOT NULL,
  -- ser_nome VARCHAR(100) NOT NULL,
  ser_datainicio DATETIME NOT NULL,
  ser_datafim DATETIME NOT NULL,
  ser_origem VARCHAR(100) NOT NULL,
  ser_destino VARCHAR(100) NOT NULL,
  ser_descricao VARCHAR(200) NOT NULL,
  ser_lugares INT(3) NOT NULL,
  mot_id INT(11) NOT NULL,
  FOREIGN KEY (mot_id) REFERENCES mot_motorista(mot_id)
  );
  
CREATE TABLE sco_servicoscondutor(
	ser_id INT,
    FOREIGN KEY (ser_id) REFERENCES ser_servicos(ser_id),
    con_id INT,
    FOREIGN KEY (con_id) REFERENCES con_condutor(con_id)
);

CREATE TABLE Int_interesse (
  pas_id INT(11) NOT NULL,
  FOREIGN KEY (pas_id) REFERENCES pas_passageiro(pas_id),
  ser_id INT(11) NOT NULL,
  FOREIGN KEY (ser_id) REFERENCES ser_servicos(ser_id));
  

CREATE TABLE tpc_tipo_contato (
  tpc_id INT(11) PRIMARY KEY NOT NULL AUTO_INCREMENT,
  tpc_descricao VARCHAR(20)
  );


CREATE TABLE mxc_motorista_tipo_contato (
  mxc_id INT PRIMARY KEY AUTO_INCREMENT,
  mot_id INT(11) NOT NULL,
  FOREIGN KEY (mot_id) REFERENCES mot_motorista(mot_id),
  tpc_id INT(11) NOT NULL,
  FOREIGN KEY (tpc_id) REFERENCES tpc_tipo_contato(tpc_id),
  mxc_descricao VARCHAR(200) 
  );
  

CREATE TABLE rec_recursos (
  rec_id INT(11) PRIMARY KEY NOT NULL AUTO_INCREMENT,
  rec_descricao VARCHAR(40) NOT NULL
  );
  

CREATE TABLE sol_solicitacao (
  sol_id INT(11) PRIMARY KEY NOT NULL AUTO_INCREMENT,
  sol_origem VARCHAR(100) NOT NULL,
  sol_destino VARCHAR(100) NOT NULL,
  sol_datainicio DATETIME NOT NULL,
  sol_datafim DATETIME NOT NULL,
  sol_qtdpessoas INT(11) NOT NULL,
  sol_descricao VARCHAR(200),
  sol_private BOOL,
  pas_id INT(11) NOT NULL,
  FOREIGN KEY (pas_id) REFERENCES pas_passageiro(pas_id));


CREATE TABLE som_solicitacao_motorista (
  som_proposta DOUBLE NOT NULL,
  sol_id INT(11) NOT NULL,
  FOREIGN KEY (sol_id) references sol_solicitacao(sol_id),
  mot_id INT(11) NOT NULL,
  FOREIGN KEY (mot_id) references mot_motorista(mot_id));


CREATE TABLE tip_tipoconta (
  tip_id INT(11) PRIMARY KEY NOT NULL AUTO_INCREMENT,
  tip_descricao VARCHAR(40) NOT NULL
  );
  

CREATE TABLE tim_tipoconta_motorista (
  tip_id INT(11) NOT NULL,
  FOREIGN KEY (tip_id) references tip_tipoconta(tip_id),
  mot_id INT(11) NOT NULL,
  FOREIGN KEY (mot_id) references mot_motorista(mot_id),
  tim_datainicio DATETIME NOT NULL,
  tim_datafim DATETIME NOT NULL
  );


CREATE TABLE tve_tipoveiculo (
  tve_id INT(11) PRIMARY KEY NOT NULL AUTO_INCREMENT,
  tve_descricao VARCHAR(50) NOT NULL
  );
  
CREATE TABLE img_imagemveiculo(
	img_id INT PRIMARY KEY AUTO_INCREMENT,
    img_foto VARCHAR(100) NOT NULL
  );

CREATE TABLE tra_transporte (
  tra_id INT(11) PRIMARY KEY NOT NULL AUTO_INCREMENT,
  tra_lugares INT(2) NOT NULL,
  tve_id INT(11) NOT NULL,
  FOREIGN KEY (tve_id) REFERENCES tve_tipoveiculo(tve_id),
  img_id INT NOT NULL,
  FOREIGN KEY (img_id) REFERENCES img_imagemveiculo(img_id)
);


CREATE TABLE txm_transporte_motorista (
  mot_id INT(11) NOT NULL,
  FOREIGN KEY (mot_id) references mot_motorista(mot_id),
  tra_id INT(11) NOT NULL,
  FOREIGN KEY (tra_id) references tra_transporte(tra_id)
  );
  

CREATE TABLE txr_transporte_recursos (
  tra_id INT(11) NOT NULL,
  FOREIGN KEY (tra_id) references tra_transporte(tra_id),
  rec_id INT(11) NOT NULL,
  FOREIGN KEY (rec_id) references rec_recursos(rec_id));
  
  
CREATE TABLE fal_faleConosco( 
  fal_id INT AUTO_INCREMENT PRIMARY KEY,
  fal_nome VARCHAR(40) NOT NULL,
  fal_email VARCHAR(60) NOT NULL,
  fal_mensagem VARCHAR(200) NOT NULL
);

CREATE TABLE ctp_condutor_tipo_contato (
  ctp_id INT PRIMARY KEY AUTO_INCREMENT,
  con_id INT(11) NOT NULL,
  FOREIGN KEY (con_id) REFERENCES con_condutor(con_id),
  tpc_id INT(11) NOT NULL,
  FOREIGN KEY (tpc_id) REFERENCES tpc_tipo_contato(tpc_id),
  ctp_descricao VARCHAR(200) 
  );
  
  

select mxc_descricao, tdo_image from usu_usuario usu 
inner join mot_motorista mot on mot.usu_id = usu.usu_id 
inner join doc_documento doc on doc.mot_id = mot.mot_id
inner join tdo_tipodocumento tdo on tdo.tdo_id = doc.tdo_id
inner join pes_pessoa pes on pes.pes_id = usu.pes_id 
inner join mxc_motorista_tipo_contato mxc on mot.mot_id = mxc.mot_id 
inner join tpc_tipo_contato tpc on tpc.tpc_id = mxc.tpc_id where usu.usu_id = 2;

select * from mot_motorista mot inner join con_condutor con on mot.mot_id = con.mot_id where mot.mot_id=1;

select * from rec_recursos;
select * from doc_documento;
select * from tdo_tipodocumento;
select * from pes_pessoa;
select * from usu_usuario;
select * from pas_passageiro;
select * from mot_motorista;
select * from mxc_motorista_tipo_contato;
select * from tpc_tipo_contato;
select * from ser_servicos;
select * from sol_solicitacao;
select * from con_condutor;

select pas_id from pas_passageiro pas inner join usu_usuario usu on usu.usu_id = pas.usu_id where usu.usu_id = 1;

-- insert into ser_servicos (ser_datacadastro, ser_datainicio, ser_datafim, ser_origem, ser_destino, ser_descricao, ser_lugares, mot_id, con_id) values 
-- ('2017-02-03', '2017-02-03', '2017-02-03', 'fatec', 'pinda', 'abcd', 12, 1, null);

select mxc_descricao from usu_usuario usu 
inner join mot_motorista mot on mot.usu_id = usu.usu_id 
inner join pes_pessoa pes on pes.pes_id = usu.pes_id 
inner join mxc_motorista_tipo_contato mxc on mot.mot_id = mxc.mot_id 
inner join tpc_tipo_contato tpc on tpc.tpc_id = mxc.tpc_id where usu.usu_id=4;

select mxc_descricao from mxc_motorista_tipo_contato where mot_id=6;

select mot.mot_id, mxc.mxc_id, tpc.tpc_id from mxc_motorista_tipo_contato mxc 
inner join mot_motorista mot on mot.mot_id = mxc.mot_id 
inner join tpc_tipo_contato tpc on tpc.tpc_id = mxc.tpc_id where mot.mot_id = 1;

-- select mxc_descricao from mxc_motorista_tipo_contato where mot_id=1;

-- delete from ser_servicos where ser_id = 2;
-- delete from pes_pessoa where pes_id = 5;
-- delete from usu_usuario where usu_id = 5;
-- delete from pas_passageiro where pas_id = 1;

insert into rec_recursos (rec_descricao) values ("Ar-condicionado");
insert into rec_recursos (rec_descricao) values ("Wi-Fi");
insert into rec_recursos (rec_descricao) values ("Televisão");
insert into rec_recursos (rec_descricao) values ("Frigobar");
insert into rec_recursos (rec_descricao) values ("Rádio");
insert into rec_recursos (rec_descricao) values ("Porta Automática");

insert into tve_tipoveiculo (tve_descricao) values ("Doblô");
insert into tve_tipoveiculo (tve_descricao) values ("Van");
insert into tve_tipoveiculo (tve_descricao) values ("Mini-Van");


insert into tpc_tipo_contato (tpc_descricao) values ("Telefone");
insert into tpc_tipo_contato (tpc_descricao) values ("Celular");
insert into tpc_tipo_contato (tpc_descricao) values ("Whatsapp");
insert into tpc_tipo_contato (tpc_descricao) values ("Email Alternativo");

-- insert into pes_pessoa (pes_nome, pes_sexo, pes_nascimento, pes_cidade, pes_estado) values ('Motorista', 'M', '1999-02-03', 'Pindamonhangaba', 'SP');
-- insert into usu_usuario (usu_email, usu_senha, usu_tipo, pes_id) values ('motorista@motorista.com', '123', 'Motorista', 1);
-- insert into mot_motorista (mot_cnpj, usu_id) values ('123456', 1);


insert into tip_tipoconta (tip_descricao) values ('Free');
insert into tip_tipoconta (tip_descricao) values ('Premium');

select mxc_descricao, tdo_image from usu_usuario usu inner join mot_motorista mot on mot.usu_id = usu.usu_id 
inner join doc_documento doc on doc.mot_id = mot.mot_id 
inner join tdo_tipodocumento tdo on tdo.tdo_id = doc.tdo_id 
inner join pes_pessoa pes on pes.pes_id = usu.pes_id 
inner join mxc_motorista_tipo_contato mxc on mot.mot_id = mxc.mot_id 
inner join tpc_tipo_contato tpc on tpc.tpc_id = mxc.tpc_id where usu.usu_id = 2;

-- insert into mxc_motorista_tipo_contato (mot_id, tpc_id, mxc_descricao) values (1, 2, '3645-8888');

-- update mxc_motorista_tipo_contato set mxc_descricao = '3645-5555' where mxc_id = 1;
-- update tpc_tipo_contato set tpc_descricao = 'Telefone' where tpc_id = 1;

/*select pes.pes_id, pes_nome, mot_cnpj, pes_sexo, pes_cidade, usu_email from usu_usuario usu 
inner join mot_motorista mot on mot.usu_id = usu.usu_id 
inner join pes_pessoa pes on pes.pes_id = usu.pes_id;

select * from usu_usuario usu inner join mot_motorista mot on mot.usu_id = usu.usu_id 
inner join pes_pessoa pes on pes.pes_id = usu.pes_id 
inner join mxc_motorista_tipo_contato mxc on mot.mot_id = mxc.mot_id 
inner join tpc_tipo_contato tpc on tpc.tpc_id = mxc.tpc_id;

select ser_id, pes_nome, ser_datainicio, ser_datafim, ser_destino, ser_descricao from ser_servicos ser 
inner join mot_motorista mot on mot.mot_id = ser.mot_id 
inner join usu_usuario usu on mot.usu_id = usu.usu_id 
inner join pes_pessoa pes on pes.pes_id = usu.pes_id;

select pes.pes_id, pes_nome, pas_cpf, pes_sexo, pes_nascimento, pes_cidade, pes_estado, usu_email 
from usu_usuario usu inner join pas_passageiro pas on pas.usu_id = usu.usu_id inner join pes_pessoa pes on pes.pes_id = usu.pes_id;


-- update pes_pessoa set pes_nome = 'motorista', pes_sexo = 'M' where pes_id = 1;
-- update usu_usuario set usu_email = 'motorista@motorista.com' where usu_id = 1;

select pes.pes_id, pes_nome, mot_cnpj, pes_sexo, pes_nascimento, pes_cidade, pes_estado, usu_email from usu_usuario usu inner join mot_motorista mot on mot.usu_id = usu.usu_id inner join pes_pessoa pes on pes.pes_id = usu.pes_id;
select * from usu_usuario usu inner join mot_motorista mot on mot.usu_id = usu.usu_id inner join pes_pessoa pes on pes.pes_id = usu.pes_id;

select pes.pes_id, pes_nome, mot_cnpj, pes_sexo, pes_nascimento, pes_cidade, pes_estado, usu_email, mxc_descricao, tpc_descricao from usu_usuario usu 
inner join mot_motorista mot on mot.usu_id = usu.usu_id 
inner join pes_pessoa pes on pes.pes_id = usu.pes_id 
inner join mxc_motorista_tipo_contato mxc on mxc.mot_id = mot.mot_id 
inner join tpc_tipo_contato tpc on mxc.tpc_id = tpc.tpc_id where pes.pes_id=1;

select usu_id, usu_email, usu_senha, usu_tipo, pes_nome from usu_usuario usu inner join pes_pessoa pes on pes.pes_id = usu.pes_id where usu_email = 'passageiro@gmail.com' and usu_senha = 'xwtd2ev7b1HQnUEytxcMnSB1CnhS8AaA9lZY8DEOgQBW5nY8NMmgCw6UAHb1RJXBafwjAszrMSA5JxxDRpUH3A==';

select mot_id, mot.usu_id from mot_motorista mot inner join usu_usuario usu on mot.usu_id = usu.usu_id where usu.usu_id = 2;

-- update cli_cliente set cli_nome = 'guilherme' where cli_id = 1;

insert into pes_pessoa (pes_nome, pes_sexo, pes_nascimento, pes_cidade, pes_estado) values ('Admin', 'M', '1999-02-03', 'Pindamonhangaba', 'SP');
insert into usu_usuario (usu_email, usu_senha, usu_tipo, pes_id) values ('admin@admin.com', 'xwtd2ev7b1HQnUEytxcMnSB1CnhS8AaA9lZY8DEOgQBW5nY8NMmgCw6UAHb1RJXBafwjAszrMSA5JxxDRpUH3A==', 'Administrador', 1);

select pes.pes_id, pes_nome, mot_cnpj, pes_sexo, pes_nascimento, pes_cidade, pes_estado, usu_email, mxc_descricao, tpc_descricao from usu_usuario usu 
inner join    mot_motorista mot on mot.usu_id = usu.usu_id 
inner join pes_pessoa pes on pes.pes_id = usu.pes_id 
inner join mxc_motorista_tipo_contato mxc on mxc.mot_id = mot.mot_id 
inner join tpc_tipo_contato tpc on mxc.tpc_id = tpc.tpc_id where pes.pes_id = 2;
*/
