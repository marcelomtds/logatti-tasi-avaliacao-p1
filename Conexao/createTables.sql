﻿create table endereco(
					  id          int identity(1, 1) not null,
					  logradouro  varchar(50)        not null,
					  numero      int                not null,
					  cep         varchar(15)        not null,
					  bairro      varchar(50)        not null,
					  complemento varchar(100)               ,
					  localidade  varchar(50)        not null,
					  uf          varchar(2)         not null,
					  constraint pk_endereco primary key (id),
					  constraint uk_endereco unique (cep)
					 );
					 
create table curso(
				   id             int identity(1, 1) not null,
				   nome           varchar(100)       not null,
				   carga_horaria  varchar(20)        not null,
				   horario_inicio varchar(10)        not null,
				   horario_fim    varchar(10)        not null,
				   numero_sala    int                        ,
				   constraint pk_curso primary key (id),
				   );					 
				   
create table professor(
					   id          int identity(1, 1) not null,
					   cpf         varchar(15)        not null,
					   nome        varchar(100)       not null,
					   telefone    varchar(30)        not null,
					   email       varchar(70)        not null,
					   salario     decimal(8, 2)      not null,
					   id_endereco int                not null,
					   constraint pk_professor primary key (id),
					   constraint fk_professor_endereco foreign key (id_endereco) references endereco(id),
					   constraint uk_professor unique (nome)
					   );
					   
create table aluno(
				    id          int identity(1, 1) not null,
					cpf         varchar(15	)      not null,
					nome        varchar(100)       not null,
					telefone    varchar(30)        not null,
					email       varchar(70)        not null,
					ra          varchar(30)        not null,
					id_curso    int                not null,
					id_endereco int                not null,
					constraint pk_aluno primary key (id),
					constraint fk_aluno_endereco foreign key (id_endereco) references endereco(id),
					constraint fk_aluno_curso foreign key (id_curso) references curso(id),
					constraint uk_aluno_ra unique (ra),
					constraint uk_aluno_cpf unique (cpf)
					);

create table curso_professor(
							 id_curso     int not null,
							 id_professor int not null,
							 constraint pk_curso_professor primary key (id_curso, id_professor),
							 constraint fk_curso_professor_curso foreign key (id_curso) references curso(id),
							 constraint fk_curso_professor_professor foreign key (id_professor) references professor(id),
							);					
				 