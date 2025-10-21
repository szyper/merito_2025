<!doctype html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>{{ $title ?? 'test' }}</title>
</head>
<body>
    <h1>{{ $title }}</h1>
    <table>
        <thead>
            <th>ID</th>
            <th>Imię</th>
            <th>Nazwisko</th>
        </thead>
        <tbody>
            @foreach($animals as $animal)
                <tr>
                    <td>{{ $animal['id'] }}</td>
                    <td>{{ $animal['name'] }}</td>
                    <td>{{ $animal['surname'] }}</td>
                </tr>
            @endforeach
        </tbody>
    </table>

</body>
</html>
