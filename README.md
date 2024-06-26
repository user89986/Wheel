# Wheel
Проект “Колесо” поможет организовать работу автомастерской, упростит процесс учета заказов и позволит эффективно управлять данными о клиентах и выполненных работах.
# Проект содержит
1. Базу данных для хранения информации о заказах и пользователях
2. Возможность добавления, удаления и редактирования заказов
3. Поиск данных 
# Главное меню программы
Простой функционал. Главное меню программы состоит из четырех основных кнопок, каждая из которых выполняет определенное действие для управления данными в программе.


![image](https://github.com/user89986/Wheel/assets/167529891/21b76439-796c-42a8-ba75-f4810b1711b2)

# Регистрация 
Нажав на данную кнопку, пользователь может зарегистрировать новый аккаунт и добавить новую запись в базу данных. Эта функция позволяет пользователям быть частью программы и сохранять свои данные для будущего использования.


![image](https://github.com/user89986/Wheel/assets/167529891/e6db1935-e801-494c-aa93-89461665a117)



# Редактирование данных 
Удаление: При нажатии на кнопку "Удаление" пользователь вводит свои данные для входа и удаляет их из базы данных. Это позволяет осуществлять управление данными и обновлять информацию, исключая устаревшие или ненужные элементы.

Редактирование: Кнопка "Редактирование" предоставляет пользователям возможность вносить изменения в существующие записи или объекты. Пользователь может изменять данные или обновлять информацию, делая ее актуальной и точной.

Данные для входа:
Пароль - @dm1n_0Progm.
Номер телефона - 84903345349


![image](https://github.com/user89986/Wheel/assets/167529891/4e41efab-a2f1-41ee-bd30-b42afdeabb48)


![image](https://github.com/user89986/Wheel/assets/167529891/1fa28b05-3b04-4ea2-878f-b9e8b45177d1)






# Поиск 
Нажав на кнопку "Поиск", пользователь может осуществить поиск по базе данных с целью поиска определенной информации или объекта. Эта функция упрощает процесс поиска требуемых данных и помогает пользователям быстро находить нужную информацию.


![image](https://github.com/user89986/Wheel/assets/167529891/e4ba9018-21eb-4f17-82c6-461ce576f5eb)

# Технические детали
1. Язык программирования C#: Для разработки программы используется язык программирования C#.
2. База данных SQ(Lite): Для хранения данных программа использует базу данных.
3. Подключение к базе данных: В коде программы присутствует логика, позволяющая устанавливать соединение с базой данных.
4. SQ(Lite)-запросы: Для выполнения операций с данными в базе данных (например, добавление новой записи, удаление, редактирование, поиск) программный код содержит SQ(Lite)-запросы.
5. Обработка данных: Полученные данные из базы данных обрабатываются и предоставляются пользователю в удобном формате.
# Заполнение базы данных
База данных генерируеться с помощью Randomsss.dll. Он рандомно берет строчки из .txt файлов (где уже написаны имена, фамилии, и другие данные) и заполняет базу данных.
```
 namespace Randomsss
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
                    string query = $"INSERT INTO DataBase ('Name', 'Surname', 'Middlename', 'NumberPhone', 'Car', 'Number', 'Region',"+
" 'Breakage', 'Price', 'Status', 'Password') VALUES ('{Name}', '{Surname}', "+
"'{Middlename}', '{NumberPhone}', '{Car}', '{Number}', '{Region}', '{Breakage}', '{Price}', '{Status}', '{Password}')";
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
}
```

# Подключение базы данных
Для подключение используеться библиотека (Microsoft.Data.Sqlite)
```
 public void Connect()
 {
     string BDPath = @"DataBase.db";
     using (var connection = new SqliteConnection($"Data Source = {BDPath}"))
     {
         connection.Open();
     }
 }
```
