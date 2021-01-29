--Select
--ANSI
--case insensitive

Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

Select * from Customers where City = 'London'


Select * from Products where CategoryID=1 or CategoryID=3

Select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products where categoryId=1 order by UnitPrice desc  --ascending  --descending

select count(*) from Products where CategoryID = 2

Select CategoryID, count(*) from products where UnitPrice>20 group by CategoryID having count(*)<10

select supplierId, count(*) from Products group by supplierId


select Products.ProductID, Products.ProductID, Products.UnitPrice, Categories.CategoryName
from products inner join Categories
on Products.CategoryID = Categories.CategoryID
where UnitPrice>10

--DTO data transformation object


select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join orders o
on o.orderId = od.orderId

select * from customers c left join Orders o
on c.CustomerID = o. CustomerID
where o.CustomerID is null