<!doctype html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Formularz</title>
</head>
<body>
    <h4>Podaj swoje dane</h4>
    <form action="/formularz" method="get">
        <label for="name">Imię</label>
        <input type="text" name="name" id="name" value="{{ $name ?? '' }}" required><br><br>

        <label for="age">Wiek</label>
        <input type="text" name="age" id="age" value="{{ $age ?? '' }}" required><br><br>

        <button type="submit">Wyślij</button>
    </form>
</body>
</html>
