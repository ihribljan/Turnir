create database Turnir;

go
use Turnir;

-- tablice
go
create table Ekipe(
	Id int identity(1,1) primary key,
	Naziv varchar(30)
);

go
create table Igraci(
	Id int identity(1,1) primary key,
	Ime varchar(20),
	Prezime varchar(20),
	EkipeId int,
	BrojGolova int,
	foreign key (EkipeId) references Ekipe(Id)
);

go
create table Rasporedi(
	Id int identity(1,1) primary key,
	EkipeIdDomacin int,
	EkipeIdGost int,
	foreign key (EkipeIdDomacin) references Ekipe(Id),
	foreign key (EkipeIdGost) references Ekipe(Id)
);

go
create table Rezultati(
	Id int identity(1,1) primary key,
	RasporediId int,
	GoloviDomacin int,
	GoloviGost int,
	foreign key (RasporediId) references Rasporedi(Id)
);

go
create table Golovi(
	Id int identity(1,1) primary key,
	RasporedId int,
	IgraciId int,
	BrojGolova int,
	foreign key (RasporedId) references Rasporedi(Id),
	foreign key (IgraciId) references Igraci(Id)
);


-- insert
insert into Ekipe(Naziv) values ('Crni biseri');
insert into Ekipe(Naziv) values ('Pungart');
insert into Ekipe(Naziv) values ('SD Kostenjar');

insert into Igraci(Ime, Prezime, EkipeId) values ('Tomi', 'Beg', 1);
insert into Igraci(Ime, Prezime, EkipeId) values ('Matija', 'Divković', 1);

insert into Igraci(Ime, Prezime, EkipeId) values ('Vito', 'Likavec', 2);
insert into Igraci(Ime, Prezime, EkipeId) values ('Andrija', 'Novosel', 2);

insert into Igraci(Ime, Prezime, EkipeId) values ('Goran', 'Bicikalj', 3);
insert into Igraci(Ime, Prezime, EkipeId) values ('Dino', 'Blažević', 3);

insert into Rasporedi(EkipeIdDomacin, EkipeIdGost) values (1, 2);
insert into Rasporedi(EkipeIdDomacin, EkipeIdGost) values (1, 3);
insert into Rasporedi(EkipeIdDomacin, EkipeIdGost) values (3, 2);

insert into Rezultati(RasporediId, GoloviDomacin, GoloviGost) values (1, 1, 1);
insert into Rezultati(RasporediId, GoloviDomacin, GoloviGost) values (2, 1, 2);
insert into Rezultati(RasporediId, GoloviDomacin, GoloviGost) values (3, 0, 2);

insert into Golovi(RasporedId, IgraciId, BrojGolova) values (1, 1, 1);
insert into Golovi(RasporedId, IgraciId, BrojGolova) values (1, 4, 1);

insert into Golovi(RasporedId, IgraciId, BrojGolova) values (2, 2, 1);
insert into Golovi(RasporedId, IgraciId, BrojGolova) values (2, 6, 2);

insert into Golovi(RasporedId, IgraciId, BrojGolova) values (3, 5, 0);
insert into Golovi(RasporedId, IgraciId, BrojGolova) values (3, 3, 1);

select i.Ime, i.Prezime, g.BrojGolova from Golovi g
join Igraci i
on g.IgraciId = i.Id
order by BrojGolova desc;

delete from Ekipe
where Id > 3;

select r.EkipeIdDomacin, r.EkipeIdGost
from Ekipe e
join Rasporedi r
on r.EkipeIdDomacin = e.Id

select * from Ekipe;

select e.Naziv, ee.Naziv from Rasporedi r
join Ekipe e
on e.Id = r.EkipeIdDomacin
join Ekipe ee
on ee.Id = r.EkipeIdGost

select * from Rasporedi;

alter table rasporedi
add Rezultat varchar(10);

alter table Rasporedi
drop column Rezultat;

select * from Igraci;

select * from rasporedi;

update  rasporedi
set Opis = 'grupa A'
where id = 3;

select * from Rezultati;

select * from Rasporedi;

alter table rasporedi
add Opis varchar(20);

select * from Ekipe;

select * from Igraci;

delete from igraci 
where id = 7;

select * from Golovi;

drop table Golovi;

select * from Igraci;

insert into Igraci(ime, Prezime, EkipeId) values('test', 'test', 1);

select * from Rasporedi;

delete from Rasporedi
where id = 5;

update Igraci
set Prezime = 'Rehorić'
where id = 8;

select e.Naziv, ee.Naziv, ra.Vrijeme from Rezultati re
join Rasporedi ra
on ra.EkipeIdDomacin = re.Id
join Ekipe e
on e.Id = ra.EkipeIdDomacin
join Ekipe ee
on ee.Id = ra.EkipeIdGost

select e.Naziv, ee.Naziv, rez.GoloviDomacin, rez.GoloviGost from Rasporedi r
join Ekipe e 
on e.Id = r.EkipeIdDomacin
join Ekipe ee
on ee.Id = r.EkipeIdGost
join Rezultati rez
on e.Id = rez.RasporediId
where e.Id = 1;

select * from Rezultati
join ekipe e
on e.Id = Rezultati.RasporediId
where e.id = 1;

select * from Rezultati;

select * from Igraci;

select * from Ekipe;

delete from Ekipe
where id  = 23;

select * from Rasporedi;

delete from Rasporedi
where id = 6;

EXEC sp_RENAME 'Rasporedi.Opis' , 'Grupa', 'COLUMN'

select * from Ekipe;

delete from Ekipe
where id > 4;

select * from Rasporedi;

select * from Igraci;

alter table rasporedi
add  GoloviGost int

select * from Rasporedi;

update Rasporedi
set GoloviGost = 0 where id = 3;

alter table rasporedi 
drop column rezultat;

create table Grupe(
	Id int identity(1,1) primary key,
	Naziv varchar(10)
);

select * from Ekipe;

alter table ekipe
add GrupeId int
foreign key(GrupeId) references Grupe(Id);

select * from rasporedi;

alter table rasporedi
add Odigrano varchar(5) check (Odigrano in('DA', 'NE', 'LIVE'));

alter table rasporedi
drop column Odigrano

update rasporedi
set odigrano = 'NE' 
where id > 0

select * from Ekipe;

select * from Strijelci

select * from Igraci;

select * from rasporedi;

delete from Rasporedi 
where id = 24;

update Rasporedi
set Odigrano = 'NE'
where id = 25;

alter table Igraci
drop column brojgolova;

alter table igraci
add BrojGolovaKnockout int

select * from Ekipe;

insert into Ekipe(Naziv) values ('Test 4');

update Ekipe
set GrupeId = 4
where id = 43

update Ekipe
set OdigraneUtakmice = 0, Pobjede = 0, Neriješeno = 0, Porazi = 0, PostignutiGolovi = 0,
PrimljeniGolovi = 0, GolRazlika = 0, Bodovi = 0
where id > 0;

alter table rasporedi
add ažurirano int not null default (0)

alter table rasporedi
drop column ažurirano

update Rasporedi
set ažurirano = 0
where id > 0;

select * from Rasporedi;

select * from Grupe;

select * from Igraci;

update igraci
set BrojGolovaGrupa = 0, BrojGolovaKnockout = 0
where id > 2;

select * from Rasporedi;

delete from Rasporedi
where id = 17;

update Rasporedi
set GoloviDomacin = 0, GoloviGost = 0
where id = 11;

update Rasporedi
set GrupeId = 1
where id < 14;

select * from Rezultati;

select * from Strijelci;

delete from Rasporedi
where id = 26;

select * from Rasporedi;

select * from Grupe;

select * from Rasporedi;

update Rasporedi
set Odigrano = 'NE'
where id > 0

select * from Igraci;

select * from Ekipe;

select * from Rasporedi;

update Ekipe
set PrimljeniGolovi = 0
where id > 0

select * from Igraci;

update Igraci
set BrojGolovaKnockout = 0
where id > 0;

update Ekipe
set GrupeId = 2
where id = 41;

select * from Ekipe;

select * from Rasporedi;

delete from Rasporedi
where id > 5;

alter table rasporedi
drop column ažurirano

update Rasporedi
set ažurirano = 0
where id = 47

select * from Ekipe;

select * from Igraci;

select * from Rasporedi;

delete from Rasporedi
where id > 0;

select * from Rasporedi;

update Rasporedi
set ažurirano = 0
where id = 48;

select * from Ekipe;

select * from Grupe;

BEGIN TRAN 
DROP TABLE Rezultati

ROLLBACK 
SELECT *
FROM Rezultati

select * from Ekipe;

update Ekipe
set GrupeId = 1
where id > 0;

select * from Igraci;

update Igraci
set BrojGolovaGrupa = 0, BrojGolovaKnockout = 0
where id > 0;

select * from Ekipe;


select * from Rasporedi;

update Rasporedi
set ažurirano = 0
where id = 49;

select * from Rasporedi

delete from Rasporedi 
where id > 0;

select * from Ekipe;

select * from Igraci;

delete from Igraci
where id > 0

delete from Ekipe
where id = 47;

select * from Ekipe;

update Ekipe
set OdigraneUtakmice = 0, Pobjede = 0, Neriješeno = 0, Porazi = 0, PostignutiGolovi = 0,
PrimljeniGolovi = 0, GolRazlika = 0, Bodovi = 0
where id > 0;

select * from Ekipe;

update Ekipe
set GrupeId = 4
where id = 62

select * from Grupe
insert into grupe(Naziv) values('3. mjesto');

select * from Ekipe;

select * from Grupe;

select * from Igraci;

select * from Rasporedi;

update Rasporedi
set ažurirano = 0
where id > 0;

update Igraci
set BrojGolovaGrupa = 1, BrojGolovaKnockout = 0
where id = 45;

select * from rezultati;

select * from Strijelci;

select * from Rasporedi;

select * from Igraci
where Prezime = 'Kramarič'

update Igraci
set BrojGolovaGrupa = 3
where Prezime = 'Čakarić' and ime = 'Luka'

select * from Igraci
where Prezime = 'Babić'

select * from Ekipe;

select * from Igraci
where ime = 'Boštjan';

update igraci
set BrojGolovaGrupa = 0, BrojGolovaKnockout = 0
where id = 162;

select * from Igraci
where Prezime = 'Ivičić'

update Igraci
set BrojGolovaGrupa = 0
where id = 65

 select * from Ekipe;

 update Ekipe
 set OdigraneUtakmice = 3, Pobjede = 1, Neriješeno = 2, Porazi = 0, PostignutiGolovi = 4,
 PrimljeniGolovi = 3, GolRazlika = 1, Bodovi = 5
 where id = 60

 select * from Ekipe;

 select COUNT(*) from Igraci;

 select * from Igraci

 update Igraci
 set BrojGolovaGrupa = 0, BrojGolovaKnockout = 0
 where id = 163

 select * from Rasporedi;

 update Rasporedi
 set ažurirano = 0
 where id > 71

 select * from Igraci;

