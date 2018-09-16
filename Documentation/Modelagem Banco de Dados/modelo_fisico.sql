sqlite3 app.db

CREATE TABLE tb_estabelecimento( 

 id_estabelecimento integer primary key autoincrement, 
 cnpj varchar(20),
 nome varchar(40),
 telefone varchar(40),
 endereco varchar(50),
 numero integer,
 complemento varchar(30),
 cidade varchar(40),
 estao (30)
                  	                 
);

CREATE TABLE tb_planta( 

 id_planta integer primary key autoincrement,
 id_marcador integer,
 id_estabelecimento integer,
 nome_popular varchar(30),
 nome_cientifico varchar(30),
 origem varchar(20),
 altura varchar(20),
 familia varchar(30),
 floracao varchar(30),
 ciclo_vida varchar(30),
 substrato varchar(100),
 tipo_adubo varchar(100),
 adubagem varchar(100),
 clima varchar(100),
 qtd_agua varchar(100),
 FOREIGN KEY(id_estabelecimento) REFERENCES tb_estabelecimentos(id_estabelecimento),
 FOREIGN KEY(id_marcador) REFERENCES tb_marcadores(id_marcador),
                  	                 
);

CREATE TABLE tb_marcador( 

 id_marcador integer primary key
                  	                 
);


INSERT INTO tb_estabelecimento
VALUES
(
 "11.111.111/1111-1", "Estabelecimento TCC", "1111-1111", "Rua Teste", 111, NULL, "Franca", "S�o Paulo"

);

INSERT INTO tb_marcadores
VALUES
(1);

INSERT INTO tb_marcadores
VALUES
(2);

INSERT INTO tb_marcadores
VALUES
(3);

INSERT INTO tb_planta
VALUES 
(1, 1, "Impatiens", "<i>Impatiens Hawkeri</i>", <i>Impatiens Hawkeri</i>, "Balsaminaceae",
 "�frica", "0.3 a 0.4 metros", "Anual", "Perene", "F�rtil, bem dren�vel e enriquecido com mat�ria org�nica",
 "Org�nico ou NPK 10-10-10", "Aduba��es Peri�dicas a cada 15 dias", "Ambiente com luz difusa, meia sombra",
 "N�o tolera seca ou sol e calor intenso", "Frequentes cerca de 3 vezes por semana" 
);

INSERT INTO tb_planta
VALUES
(2, 1,"Cravina", "<i>Dianthus chinensis</i>", "Caryophyllaceae", "�sia, Europa", "0.1 a 0.3 metros", "Anual",
 "Bienal, Perene", "Solo F�rtil, bem dren�vel e enriquecido com mat�ria org�nica", "Org�nico ou NPK 15-10-10",
 "Aduba��es Peri�dicas a cada 15 dias", "Deve ser cultivada em sol pleno, min�mo de 3 horas de sol.", 
 "Prefer�ncia por clima frio.",  "Regas regulares de 3 vezes por semana."
);

INSERT INTO tb_planta
(3, 1,"Cris�ntemo", "<i>Chrysanthemum morifolium</i>", "Asteraceae", "�sia, China, Jap�o", "0.3 a 0.4 metros",
 "Inverno", "Perene","Solo F�rtil, bem dren�vel e enriquecido com mat�ria org�nica", "Org�nico ou NPK 10-15-10",
 "Aduba��es Peri�dicas a cada 15 dias", "Deve ser cultivada a meia sombra.", "Se adapta bem ao clima de diversas regi�es.",
 "Regas regulares de 3 vezes por semana."
);
