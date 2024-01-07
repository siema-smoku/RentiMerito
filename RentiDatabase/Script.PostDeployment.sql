if not exists (select 1 from dbo.[Cars])
begin
	insert into dbo.[Cars] (CarBrand, CarName, IsRented)
	values ('Audi', 'A6', 0),
	('Mercedes-Benz','C180',0),
	('BMW', 'E36', 1),
	('Audi', 'A3', 0),
	('Mercedes-Benz','AMG G63',1),
	('Toyota','CH-R',0),
	('Volkswagen','Gold',0),
	('Toyota','Corolla',0),
	('Mercedes-Benz','E220',1),
	('Audi','S5',0),
	('Toyota','Supra',1);
end