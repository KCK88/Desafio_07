create database BancoEscola;

create table Alunos(
                       Id int,
                       Nome varchar(255) not null,
                       Idade int not null,
                       PRIMARY KEY (Id)
);

create table Cursos(
                       Id int,
                       Nome varchar(255) not null ,
                       PRIMARY KEY (Id)
);

create table AlunoCursos(
                            IdAluno int,
                            IdCurso int,
                            Status varchar(255) not null,
                            Nota int not null,
                            PRIMARY KEY (IdAluno, IdCurso),
                            FOREIGN KEY (IdAluno) references Alunos(Id),
                            FOREIGN KEY (IdCurso) references Cursos(Id)
);