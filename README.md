[Connection.txt](https://github.com/user89986/Wheel/files/15094004/Connection.txt)[Random.txt](https://github.com/user89986/Wheel/files/15093969/Random.txt)![image](https://github.com/user89986/Wheel/assets/167529891/9b95eab0-57e7-4a3f-9e84-ad9777998fe1)![image](https://github.com/user89986/Wheel/assets/167529891/de1c8884-7307-44f9-80ca-6c77295ab658)# Wheel
Проект “Колесо” поможет организовать работу автомастерской, упростит процесс учета заказов и позволит эффективно управлять данными о клиентах и выполненных работах.
# Проект содержит
1. Базу данных для хранения информации о заказах и пользователях
2. Возможность добавления, удаления и редактирования заказов
3. Поиск данных 
# Главное меню программы
Простой функционал. Главное меню программы состоит из четырех основных кнопок, каждая из которых выполняет определенное действие для управления данными в программе.
![Снимок экрана (14)](https://github.com/user89986/Wheel/assets/167529891/28c17cfa-02bd-47ec-a04d-fd8745c6ad32)
# Регистрация 
Нажав на данную кнопку, пользователь может зарегистрировать новый аккаунт и добавить новую запись в базу данных. Эта функция позволяет пользователям быть частью программы и сохранять свои данные для будущего использования.
![Снимок экрана (15)](https://github.com/user89986/Wheel/assets/167529891/a3e44566-ece2-42c5-ace0-ba8475a6cc81)
# Удаление и редактирование
Удаление: При нажатии на кнопку "Удаление" пользователь вводит свои данные для входа и удаляет их из базы данных. Это позволяет осуществлять управление данными и обновлять информацию, исключая устаревшие или ненужные элементы.
Редактирование: Кнопка "Редактирование" предоставляет пользователям возможность вносить изменения в существующие записи или объекты. Пользователь может изменять данные или обновлять информацию, делая ее актуальной и точной.
![Снимок экрана (16)](https://github.com/user89986/Wheel/assets/167529891/60d7bdfe-2364-42be-8817-63a355e905d6)
# Поиск 
Нажав на кнопку "Поиск", пользователь может осуществить поиск по базе данных с целью поиска определенной информации или объекта. Эта функция упрощает процесс поиска требуемых данных и помогает пользователям быстро находить нужную информацию.
![Снимок экрана (17)](https://github.com/user89986/Wheel/assets/167529891/b0705535-9823-4b8f-aa90-fe1c4f6d25af)
# Технические детали
1. Язык программирования C#: Для разработки программы используется язык программирования C#.
2. База данных SQ(Lite): Для хранения данных программа использует базу данных.
3. Подключение к базе данных: В коде программы присутствует логика, позволяющая устанавливать соединение с базой данных.
4. SQ(Lite)-запросы: Для выполнения операций с данными в базе данных (например, добавление новой записи, удаление, редактирование, поиск) программный код содержит SQ(Lite)-запросы.
5. Обработка данных: Полученные данные из базы данных обрабатываются и предоставляются пользователю в удобном формате.
# Заполнение базы данных
База данных генерируеться с помощью Randomsss.dll. Он рандомно берет строчки из .txt файлов (где уже написаны имена, фамилии, и другие данные) и заполняет базу данных.
[Uplonamespace Randomsss
{
    public class Random1
    {
        public void Connection()
        {
            string db = @"DataBase.db";
            using (var connection = new SqliteConnection($"Data Source = {db}"))
            {
                connection.Open();

                for (int i = 0; i < 200; i++)
                {
                    string Name, Surname, Middlename, NumberPhone, Car, Number, Region, Breakage, Price, Status, Password;

                    // Чтение данных из текстовых файлов
                    Name = ReadFromFile(@"Name.txt");
                    Surname = ReadFromFile(@"Surname.txt");
                    Middlename = ReadFromFile(@"Middlename.txt");
                    NumberPhone = ReadFromFile(@"NumberPhone.txt");
                    Car = ReadFromFile(@"Car.txt");
                    Number = ReadFromFile(@"Number.txt");
                    Region = ReadFromFile(@"Region.txt");
                    Breakage = ReadFromFile(@"Breakage.txt");
                    Price = ReadFromFile(@"Price.txt");
                    Status = ReadFromFile(@"Status.txt");
                    Password = ReadFromFile(@"Password.txt");

                    // Запись данных в базу данных
                    string query = $"INSERT INTO DataBase ('Name', 'Surname', 'Middlename', 'NumberPhone', 'Car', 'Number', 'Region', 'Breakage', 'Price', 'Status', 'Password') VALUES ('{Name}', '{Surname}', '{Middlename}', '{NumberPhone}', '{Car}', '{Number}', '{Region}', '{Breakage}', '{Price}', '{Status}', '{Password}')";
                    using (SqliteCommand command = connection.CreateCommand())
                    {
                        command.CommandText = query;
                        command.ExecuteNonQuery();
                    }
                }
                connection.Close();
            }
        }
        public static string ReadFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, lines.Length);
            return lines[randomIndex];
        }
    }
}ading Random.txt…]()
# Подключение базы данных
Для подключение используеться библиотека (Microsoft.Data.Sqlite)
[Uplo public void Connect()
 {
     string BDPath = @"DataBase.db";
     using (var connection = new SqliteConnection($"Data Source = {BDPath}"))
     {
         connection.Open();
         

     }
     
 }ading Connection.txt…]()
