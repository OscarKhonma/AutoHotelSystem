-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Сен 21 2023 г., 06:23
-- Версия сервера: 10.4.26-MariaDB
-- Версия PHP: 8.0.22

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `auto_hotel_system`
--

-- --------------------------------------------------------

--
-- Структура таблицы `clients`
--

CREATE TABLE `clients` (
  `id` int(11) NOT NULL,
  `first_name` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `last_name` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `phone` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `country` varchar(100) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `clients`
--

INSERT INTO `clients` (`id`, `first_name`, `last_name`, `phone`, `country`) VALUES
(1, 'Alex', 'Stone', '89978887777', 'Russia'),
(2, 'Max', 'Tan', '89961112222', 'Russia'),
(3, 'Ive', 'Khan', '89995556666', 'Russia'),
(6, 'Oscar', 'Khonma', '0', 'Russia');

-- --------------------------------------------------------

--
-- Структура таблицы `reservations`
--

CREATE TABLE `reservations` (
  `id` int(11) NOT NULL,
  `room_number` int(11) NOT NULL,
  `client_id` int(11) NOT NULL,
  `date_in` date NOT NULL,
  `date_out` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `reservations`
--

INSERT INTO `reservations` (`id`, `room_number`, `client_id`, `date_in`, `date_out`) VALUES
(1, 3, 1, '2023-07-29', '2023-07-30'),
(2, 7, 2, '2023-07-29', '2023-07-30'),
(4, 1, 3, '2023-09-22', '2023-09-22'),
(5, 6, 6, '2023-09-22', '2023-09-30');

-- --------------------------------------------------------

--
-- Структура таблицы `rooms`
--

CREATE TABLE `rooms` (
  `number` int(11) NOT NULL,
  `type` int(11) NOT NULL,
  `phone` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `free` varchar(10) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `rooms`
--

INSERT INTO `rooms` (`number`, `type`, `phone`, `free`) VALUES
(1, 1, '12345', 'YES'),
(2, 1, '12345', 'YES'),
(3, 2, '12345', 'NO'),
(5, 3, '12345', 'YES'),
(6, 4, '0', 'NO'),
(7, 3, '12345', 'NO');

-- --------------------------------------------------------

--
-- Структура таблицы `rooms_type`
--

CREATE TABLE `rooms_type` (
  `id` int(11) NOT NULL,
  `label` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  `price` decimal(9,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `rooms_type`
--

INSERT INTO `rooms_type` (`id`, `label`, `price`) VALUES
(1, 'single', '1000.00'),
(2, 'double', '2000.00'),
(3, 'family', '3000.00'),
(4, 'suite', '5000.00');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `password` varchar(50) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `username`, `password`) VALUES
(1, 'admin', 'admin');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `clients`
--
ALTER TABLE `clients`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `reservations`
--
ALTER TABLE `reservations`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_room_number` (`room_number`),
  ADD KEY `fk_client_id` (`client_id`);

--
-- Индексы таблицы `rooms`
--
ALTER TABLE `rooms`
  ADD PRIMARY KEY (`number`),
  ADD KEY `fk_type_id` (`type`);

--
-- Индексы таблицы `rooms_type`
--
ALTER TABLE `rooms_type`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `clients`
--
ALTER TABLE `clients`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `reservations`
--
ALTER TABLE `reservations`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `rooms_type`
--
ALTER TABLE `rooms_type`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `reservations`
--
ALTER TABLE `reservations`
  ADD CONSTRAINT `fk_client_id` FOREIGN KEY (`client_id`) REFERENCES `clients` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_room_number` FOREIGN KEY (`room_number`) REFERENCES `rooms` (`number`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `rooms`
--
ALTER TABLE `rooms`
  ADD CONSTRAINT `fk_type_id` FOREIGN KEY (`type`) REFERENCES `rooms_type` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
