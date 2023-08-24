USE RestaurantAPI;

-- Criação da tabela Clients
CREATE TABLE Clients (
   Id INT PRIMARY KEY IDENTITY(1,1),
   ClientName NVARCHAR(255) NOT NULL,
   Email NVARCHAR(255) NOT NULL,
   ClientAddress NVARCHAR(255) NOT NULL,
   City NVARCHAR(80) NOT NULL,
   Uf NVARCHAR(2) NOT NULL,
   Cpf NVARCHAR(11) NOT NULL,
   ClientStatus INT NOT NULL
);

-- Inserção de dados na tabela Clients
INSERT INTO Clients (ClientName, Email, ClientAddress, City, Uf, Cpf, ClientStatus)
VALUES
   ('João Silva', 'joao@example.com', 'Rua das Flores', 'São Paulo', 'SP', '94065965047', 1),
   ('Maria Souza', 'maria@example.com', 'Avenida Central', 'Rio de Janeiro', 'RJ', '91550145002', 1),
   ('Pedro Santos', 'pedro@example.com', 'Rua da Liberdade', 'Belo Horizonte', 'MG', '51801997004', 2),
   ('Ana Ferreira', 'ana@example.com', 'Rua dos Coqueiros', 'Salvador', 'BA', '71859569005', 1),
   ('Carlos Lima', 'carlos@example.com', 'Rua das Palmeiras', 'Curitiba', 'PR', '59455209004', 2),
   ('Mariana Vieira', 'mariana@example.com', 'Avenida das Águas', 'Fortaleza', 'CE', '63464522075', 1),
   ('Lucas Oliveira', 'lucas@example.com', 'Rua das Oliveiras', 'Recife', 'PE', '39595799009', 1),
   ('Laura Rodrigues', 'laura@example.com', 'Avenida dos Girassóis', 'Porto Alegre', 'RS', '82265350001', 2),
   ('Gabriel Costa', 'gabriel@example.com', 'Rua das Estrelas', 'Brasília', 'DF', '38747791063', 1),
   ('Isabela Almeida', 'isabela@example.com', 'Avenida das Rosas', 'Belém', 'PA', '02894053002', 2),
   ('Rafael Martins', 'rafael@example.com', 'Rua das Pedras', 'Manaus', 'AM', '98006578001', 1),
   ('Lívia Pereira', 'livia@example.com', 'Avenida das Flores', 'Vitória', 'ES', '36570699091', 1);

-- Criação da tabela Restaurants
CREATE TABLE Restaurants (
   Id INT PRIMARY KEY IDENTITY(1,1),
   RestaurantName NVARCHAR(255) NOT NULL,
   RestaurantAddress NVARCHAR(255) NOT NULL,
   ContactName NVARCHAR(255) NOT NULL,
   PhoneNumber NVARCHAR(14) NOT NULL,
   Cnpj NVARCHAR(14) NOT NULL,
   City NVARCHAR(80) NOT NULL,
   Uf NVARCHAR(2) NOT NULL
);

-- Inserção de dados na tabela Restaurants
INSERT INTO Restaurants (RestaurantName, RestaurantAddress, ContactName, PhoneNumber, Cnpj, City, Uf)
VALUES
   ('Cantinho do Sabor', 'Rua das Oliveiras', 'Ana Santos', '12345678901', '80011161000110', 'São Paulo', 'SP'),
   ('Sabor Gourmet', 'Avenida Central', 'Carlos Silva', '23456789012', '24363057000113', 'Rio de Janeiro', 'RJ'),
   ('Delícias da Terra', 'Rua dos Coqueiros', 'Mariana Vieira', '34567890123', '98075605000146', 'Belo Horizonte', 'MG'),
   ('Mar & Terra Restaurante', 'Avenida das Flores', 'Lucas Oliveira', '45678901234', '69911037000178', 'Salvador', 'BA'),
   ('Sabor Artesanal', 'Rua das Estrelas', 'Laura Rodrigues', '56789012345', '60350784000100', 'Curitiba', 'PR'),
   ('Sabores do Nordeste', 'Avenida dos Girassóis', 'Gabriel Costa', '67890123456', '79513975000173', 'Fortaleza', 'CE'),
   ('Gastronomia Pernambucana', 'Rua da Liberdade', 'Isabela Almeida', '78901234567', '63636697000101', 'Recife', 'PE'),
   ('Culinária Gaúcha', 'Avenida das Rosas', 'Rafael Martins', '89012345678', '42128862000144', 'Porto Alegre', 'RS');

-- Criação da tabela Dishes
CREATE TABLE Dishes (
   Id INT PRIMARY KEY IDENTITY(1,1),
   DishName NVARCHAR(255) NOT NULL,
   Description NVARCHAR(400) NOT NULL,
   Price DECIMAL(18, 2) NOT NULL
);

-- Inserção de dados na tabela Dishes
INSERT INTO Dishes (DishName, Description, Price)
VALUES
   ('Feijoada', 'Prato tradicional brasileiro, composto por feijão preto cozido com diversos tipos de carne.', 25.99),
   ('Risoto de Funghi', 'Risoto cremoso preparado com cogumelos funghi secchi, vinho branco e parmesão.', 29.99),
   ('Moqueca de Peixe', 'Igualmente saborosa e colorida, essa moqueca é feita com peixe fresco, leite de coco e dendê.', 22.99),
   ('Bobó de Camarão', 'Prato típico da culinária baiana, feito com camarões e aipim cozido, temperado com dendê e leite de coco.', 34.99),
   ('Escondidinho de Carne Seca', 'Camadas de purê de mandioca intercaladas com carne seca desfiada e requeijão.', 19.99),
   ('Tutu à Mineira', 'Prato da culinária mineira, feito com feijão, farinha de mandioca, linguiça e couve.', 18.99),
   ('Bobó de Frango', 'Variação do bobó tradicional, essa versão é preparada com frango desfiado.', 21.99),
   ('Coxinha', 'Salgado brasileiro em formato de coxa de galinha, com massa de batata e recheio de frango.', 3.99),
   ('Feijão Tropeiro', 'Feijão temperado com linguiça, bacon, ovos e farinha de mandioca, prato típico do interior do Brasil.', 16.99),
   ('Camarão à Paulista', 'Camarões refogados com alho, cebola, tomate, pimentão e salsinha.', 28.99),
   ('Pastel de Feira', 'Pastel recheado com diversos sabores, como carne, queijo, palmito, frango e outros.', 4.99),
   ('Baião de Dois', 'Prato nordestino feito com arroz e feijão verde, cozidos juntos com carne seca e temperos.', 17.99),
   ('Quibe', 'Salgado de origem árabe feito de carne moída, trigo e temperos, geralmente frito.', 5.99),
   ('Vatapá', 'Prato típico da Bahia, feito com pão amanhecido, camarões secos, leite de coco e dendê.', 20.99),
   ('Pão de Queijo', 'Pequenos pães de queijo assados, feitos com polvilho, queijo e leite.', 3.99);

-- Criação da tabela Orders
CREATE TABLE Orders (
   Id INT PRIMARY KEY IDENTITY(1,1),
   ClientId INT NOT NULL,
   RestaurantId INT NOT NULL,
   OrderDate DATETIME NOT NULL,
   TotalPrice DECIMAL(18, 2) NOT NULL,
   OrderStatus INT NOT NULL,
   FOREIGN KEY (ClientId) REFERENCES Clients(Id),
   FOREIGN KEY (RestaurantId) REFERENCES Restaurants(Id)
);

-- Inserção de dados na tabela Orders
INSERT INTO Orders (ClientId, RestaurantId, OrderDate, TotalPrice, OrderStatus)
VALUES
   (1, 1, '2023-08-10 12:30:00', 50.00, 1),
   (2, 3, '2023-08-11 18:15:00', 75.00, 2),
   (3, 2, '2023-08-12 20:45:00', 60.00, 3),
   (1, 4, '2023-08-13 14:00:00', 40.00, 4),
   (4, 5, '2023-08-14 19:30:00', 90.00, 2),
   (2, 1, '2023-08-15 08:45:00', 55.00, 1),
   (3, 7, '2023-08-16 16:20:00', 70.00, 4),
   (5, 3, '2023-08-17 12:10:00', 65.00, 5),
   (7, 5, '2023-08-18 09:00:00', 85.00, 1),
   (8, 4, '2023-08-19 17:30:00', 30.00, 5),
   (9, 3, '2023-08-20 14:45:00', 55.00, 5),
   (10, 8, '2023-08-21 21:00:00', 70.00, 2),
   (11, 7, '2023-08-22 11:20:00', 80.00, 3),
   (12, 6, '2023-08-23 16:40:00', 45.00, 4),
   (1, 5, '2023-08-24 13:15:00', 95.00, 2),
   (3, 1, '2023-08-25 09:30:00', 50.00, 4),
   (8, 2, '2023-08-26 17:00:00', 65.00, 2),
   (9, 8, '2023-08-27 15:25:00', 75.00, 1),
   (11, 5, '2023-08-28 10:45:00', 35.00, 3),
   (12, 4, '2023-08-29 19:50:00', 60.00, 5);

-- Criação da tabela OrderDishes
CREATE TABLE OrderDishes (
   Id INT PRIMARY KEY IDENTITY(1,1),
   OrderId INT NOT NULL,
   DishId INT NOT NULL,
   Quantity INT NOT NULL,
   FOREIGN KEY (OrderId) REFERENCES Orders(Id),
   FOREIGN KEY (DishId) REFERENCES Dishes(Id)
);

-- Inserção de dados na tabela OrderDishes
INSERT INTO OrderDishes (OrderId, DishId, Quantity)
VALUES
   (1, 2, 1),
   (3, 3, 1),
   (5, 1, 1),
   (6, 2, 1),
   (8, 5, 1),
   (10, 9, 1),
   (11, 8, 1),
   (12, 15, 1),
   (14, 6, 1),
   (16, 7, 1),
   (17, 13, 1),
   (19, 12, 1);