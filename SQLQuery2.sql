--Select Yorum satırı -- ile oluyor
-- ANSII
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City = 'London'

--case insensetive
select *from Products where CategoryID=1 or CategoryID=3

select *from Products where CategoryID=1 and UnitPrice >10

select *from Products order by UnitPrice asc --ascending artan demek

select *from Products where CategoryID=1 order by UnitPrice desc --descending düşen demek

select count(*) from Products where CategoryID=2

--hangi kategoride kaç farklı ürünümüz var ??
select CategoryID,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10



select Products.ProductID,Products.ProductName,Products.UnitPrice, Categories.CategoryName from Products inner join Categories on Products.CategoryID = Categories.CategoryID order by UnitPrice desc

--DTO = Data Transformation Object
-- Köşeli parantezi tablodaki isimlerde eğer boşluk varsa onu başka bir şey olarak almaması için kullandık.
select *from Products p inner join[Order Details] od on p.ProductID = od.ProductID

select *from Products p left join[Order Details] od on p.ProductID = od.ProductID

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null