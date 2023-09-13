SELECT  P."ProductName", C."CategorieName"
FROM Products p
LEFT JOIN CategoriesProducts CP
   ON P.ProductID = CP.ProductID
LEFT JOIN Categories C
   ON CP.CategorieID = C.CategorieID;