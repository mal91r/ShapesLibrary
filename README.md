SQL-запрос

Пусть:
Products - таблица со столбцами Name и ID

Categories - таблица со столбцами Name и ID

ProductInCategory - таблица со столбцами ProductID и CategoryID

Тогда запрос будет выглядеть так:

select p.Name "Product", c.Name "Category" from Products as p 
  left join ProductInCategory as pc on p.ID = pc.ProductID
  left join Categories as c on pc.CategoryID = c.ID
