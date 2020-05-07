create table endereco(
					  id          int identity(1, 1) not null,
					  logradouro  varchar(100)       not null,
					  numero      int                not null,
					  cep         varchar(8)         not null,
					  bairro      varchar(50)        not null,
					  complemento varchar(100)               ,
					  localidade  varchar(100)       not null,
					  uf          varchar(2)         not null,
					  constraint pk_endereco primary key (id)
					 );
					 
create table curso(
				   id             int identity(1, 1) not null,
				   nome           varchar(100)       not null,
				   carga_horaria  int                not null,
				   horario_inicio varchar(5)         not null,
				   horario_fim    varchar(5)         not null,
				   numero_sala    int                        ,
				   constraint pk_curso primary key (id)
				   );					 
				   
create table professor(
					   id          int identity(1, 1) not null,
					   cpf         varchar(11)        not null,
					   nome        varchar(100)       not null,
					   telefone    varchar(11)        not null,
					   email       varchar(70)        not null,
					   salario     decimal(8, 2)      not null,
					   id_endereco int                not null,
					   constraint pk_professor primary key (id),
					   constraint fk_professor_endereco foreign key (id_endereco) references endereco(id),
					   constraint uk_professor unique (nome)
					   );
					   
create table aluno(
				    id          int identity(1, 1) not null,
					cpf         varchar(11	)      not null,
					nome        varchar(100)       not null,
					telefone    varchar(11)        not null,
					email       varchar(70)        not null,
					ra          varchar(30)        not null,
					id_curso    int                not null,
					id_endereco int                not null,
					constraint pk_aluno primary key (id),
					constraint fk_aluno_endereco foreign key (id_endereco) references endereco(id),
					constraint fk_aluno_curso foreign key (id_curso) references curso(id),
					constraint uk_aluno unique (ra, cpf, telefone, email)
					);

create table curso_professor(
							 id_curso     int not null,
							 id_professor int not null,
							 constraint pk_curso_professor primary key (id_curso, id_professor),
							 constraint fk_curso_professor_curso foreign key (id_curso) references curso(id),
							 constraint fk_curso_professor_professor foreign key (id_professor) references professor(id)
							);					
				 