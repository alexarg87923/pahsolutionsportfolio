CREATE USER 'PAHSolutionsUser'@'localhost' IDENTIFIED BY 'AdminLikesDick123!';

CREATE TABLE Contact (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL,
    Description VARCHAR(255) NOT NULL,
    IsNDARequired BOOLEAN
);

GRANT ALL PRIVILEGES ON PAHSolutions.Contact TO 'PAHSolutionsUser'@'localhost';