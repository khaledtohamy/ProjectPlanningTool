
  IF NOT EXISTS (SELECT 1 FROM [Category] WHERE Code='Feature')
  BEGIN
	INSERT INTO [Category] (Name,Code) VALUES('Feature','Feature')
  END

IF NOT EXISTS (SELECT 1 FROM [Category] WHERE Code='Bug')
  BEGIN
	INSERT INTO [Category] (Name,Code) VALUES('Bug','Bug')
  END

  
IF NOT EXISTS (SELECT 1 FROM [Category] WHERE Code='Idea')
  BEGIN
	INSERT INTO [Category] (Name,Code) VALUES('Idea','Idea')
  END
