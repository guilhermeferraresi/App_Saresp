create database dbSaresp_2024;
use dbsaresp_2024;
-- drop database saresp_2024;
create table tbProfessorAplicador(
IdProfessor int primary key auto_increment,
Nome varchar(150),
cpf decimal(11,0),
rg decimal(9,0),
telefone decimal(11,0),
Data_nasc datetime
);

create table tbAluno(
IdAluno int primary key auto_increment,
Nome varchar(150),
email varchar(50),
telefone decimal(11,0),
serie char(2),
turma varchar(40),
data_nasc datetime
);

Delimiter $$
create procedure sp_insertAluno(vnome varchar(150), vemail varchar(50), vtelefone decimal(11,0), vserie char(2), vturma varchar(40), vdata_nasc datetime)
begin
	insert into tbAluno(nome, email, telefone, serie, turma, data_nasc) values(vnome, vemail, vtelefone, vserie, vturma, vdata_nasc);
end
$$

Delimiter $$
create procedure sp_insertProfessor(vnome varchar(150), vcpf decimal(11,0), vrg decimal(9,0), vtelefone decimal(11,0), vdata_nasc datetime)
begin
	insert into tbProfessorAplicador(nome, cpf, rg, telefone, data_nasc) values(vnome, vcpf, vrg, vtelefone, vdata_nasc);
end
$$