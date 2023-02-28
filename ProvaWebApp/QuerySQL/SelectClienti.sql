SELECT [Name]
      ,[Surname]
      ,[Eta]
      ,[Piva]
      ,cc.colore
      
  FROM [master].[dbo].[clienti] clienti
  JOIN colore_capelli cc ON clienti.colore_capelli=cc.id
  WHERE clienti.Stato_Record = 1
  ORDER BY Eta