# DataBase-Northwind-Products-table
Работа с базовой БД "Nordwind" на основе таблицы Продуктов

## Gif отображение таблицы
![Gif_base](https://user-images.githubusercontent.com/108891719/200177359-90e51ceb-be80-4ca6-9289-4fd29d7a7580.gif)

Программа осуществляет поиск продуктов по наименованию, а также сохраняет выбранные строки в блокнот.

## В случае, если не установлена базовая БД в Visual Studio

Скачать скрипт для подключения: 
https://raw.githubusercontent.com/microsoft/sql-server-samples/master/samples/databases/northwind-pubs/instnwnd.sql

Как подключить БД Northwind:
1. В поле для запросов выполнить скопированный скрипт 
2. Выполняем скрипт: Выбираем "Локально" - MSSQLLocalBD - "Подключиться")
3. Заходим в "Обзреватель объектов SQL Server"
4. Через "Свойства" копируем строку (путь) "Текущие параметры подключения" - "Файл данных"
5. Заходим в "Обозреватель серверов" - ПКМ - "Добавить подключение" -\\
6. Изменяем источник данных на "Файл базы данных Microsoft SQL Server" и добавляем в Имя файла базы данных скопированную строку
7. (Проверяем подключение)
8. Ок
