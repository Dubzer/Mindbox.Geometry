SELECT Products.Name, Categories.Name
  FROM Products
LEFT JOIN ProductCategories
  ON Products.ID = ProductCategories.ProductId
LEFT JOIN Categories
  ON ProductCategories.CaregoryID = Categories.ID
