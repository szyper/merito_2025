<!doctype html>
<html lang=pl>
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Formularz</title>
</head>
<body>
    <h4>Podaj swoje dane</h4>

    {{-- wyswietlenie bledow walidacji formularza --}}
    @if($errors->any())
        <div style="color:red;">
            <ul>
                @foreach($errors->all() as $error)
                    <li>{{ $error }}</li>
                @endforeach
            </ul>
        </div>
    @endif
    <form action="/formularz1" method="get" novalidate>
        <label for="name">Imię</label>
{{--        <input type="text" name="name" id="name" value="{{ $name ?? '' }}" required><br><br>--}}
        <input type="text" name="name" id="name" value="{{ old('name') }}" required>
        {{-- Błąd dla pola name --}}
        @error('name')
            <div class="error">{{ $message }}</div>
        @enderror
        <br><br>

        <label for="age">Wiek:</label>
{{--        <input type="number" name="age" id="age" value="{{ $age ?? '' }}" required><br><br>--}}
        <input type="number" name="age" id="age" value="{{ old('age') }}" required>
        @error('age')
        <div class="error">{{ $message }}</div>
        @enderror
        <br><br>

        <button type="submit">Wyślij</button>
    </form>
</body>
</html>
