create table Otopark(ParkyeriID int primary key identity,DoluBos bit not null,ParkyeriKodu nvarchar(4) )

create table Araclar(AracID int primary key identity(100,1),

AracPlakasi nvarchar(10) not null constraint UNQ1
unique check 
(AracPlakasi like'[0-9][0-9][ ][A-Z][ ][0-9][0-9]' OR AracPlakasi like '[0-9][0-9][ ][A-Z][ ][0-9][0-9][0-9][0-9]' 
OR AracPlakasi like '[0-9][0-9][ ][A-Z][ ][0-9][0-9][0-9][0-9]'OR AracPlakasi like '[0-9][0-9][ ][A-Z][A-Z][ ][0-9]'
or AracPlakasi like '[0-9][0-9][ ][A-Z][A-Z][ ][0-9][0-9]'or AracPlakasi like '[0-9][0-9][ ][A-Z][A-Z][ ][0-9][0-9][0-9]'
or AracPlakasi like '[0-9][0-9][ ][A-Z][A-Z][ ][0-9][0-9][0-9][0-9]'
or AracPlakasi like '[0-9][0-9][ ][A-Z][A-Z][A-Z][ ][0-9][0-9]'or AracPlakasi like '[0-9][0-9][ ][A-Z][A-Z][A-Z][ ][0-9][0-9][0-9]' 
or AracPlakasi like '[0-9][0-9][ ][A-Z][A-Z][A-Z][ ][0-9][0-9][0-9][0-9]'),
GirisSaati datetime not null,ParkyeriID int references Otopark(ParkyeriID),Durum bit )
 

create table AracOtopark(AracOtoparkID int primary key identity(200,10),AracID int references Araclar(AracID),
ParkyeriID int references Otopark(ParkyeriID),CýkýsSaati datetime unique null,Ucret money null )

drop table Araclar
drop table Otopark
drop table AracOtopark

alter database scoped configuration set identity_cache=off
--select AracPlakasi,Ucret from Araclar inner join AracOtopark on Araclar.AracID=AracOtopark.AracID 

create procedure gp_Araclar
as
select AracID,AracPlakasi,GirisSaati,ParkyeriID from Araclar where Durum=1
exec gp_Araclar