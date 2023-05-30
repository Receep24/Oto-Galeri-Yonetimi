Create Database OtoGaleriYönetimi
Go
Use OtoGaleriYönetimi
Go
Create Table AdminUsers
(
UserId int Identity Primary Key,
FirstName varchar(50) not null,
LastName varchar(50) not null,
UserName varchar(50) not null,
Password varchar(50)
)
Create Table CustomerUsers
(
MusteriId int Identity Primary Key,
FirstName varchar(50) not null,
LastName varchar(50) not null,
UserName varchar(50) not null,
Password varchar(50)
)
Create Table Arabalar
(
ArabaId int Identity Primary Key,
Marka varchar(50) not null,
Model varchar(50) not null,
Plaka varchar(50) not null,
Vites varchar(50) not null,
Fiyat varchar(50) not null,
KayitTarihi varchar(50) not null,
AracResmi varchar(100)
)
Create Table Customers
(
MusteriId int Identity Primary Key,
ArabaId int not null,
Ad varchar(50) not null,
Soyad varchar(50) not null,
Telefon varchar(50) not null,
Email varchar(50) not null,
Fiyat varchar(50) 
)
Create Table KiralanmisAraba
(
KiraNo int Identity Primary Key,
MusteriId int not null,
AdSoyad varchar(50) not null,
ArabaId int not null,
GünlükFiyat varchar(50) not null,
KacGün varchar(50) not null,
ToplamÜcret varchar(50) not null,
KiralananTarih varchar(50) 
)
Create Table KiralikAraclar
(
KiralikNo int Identity Primary Key,
ArabaId int not null,
Marka varchar(50) not null,
Model varchar(50) not null,
GünlükFiyat varchar(50) not null,
AracResim varchar(100) 
)
Create Table SatilanArabalar
(
SatilanNo int Identity Primary Key,
ArabaId int not null,
AlisFiyati varchar(50) not null,
SatisFiyati varchar(50) not null,
Kar varchar(50) 
)
Create Table SatilikAraclar
(
SatilikNo int Identity Primary Key,
ArabaId int not null,
Marka varchar(50) not null,
Plaka varchar(50) not null,
Model varchar(50) not null,
Vites varchar(50) not null,
Km varchar(50) not null,
Fiyat varchar(50) not null,
AracResim varchar(100)
)
