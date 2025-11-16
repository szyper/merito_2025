@extends('layouts.custom')

@section('title', 'Dane użytkownika')

@section('content')
    <h4>Dane użytkownika pobrane z formularza</h4>
    <p><strong>Imię: </strong>{{ $name }}</p>
    <p><strong>Wiek: </strong>{{ $age }}</p>

    <a href="{{ route('form', ['name' => $name, 'age' => $age]) }}">Powrót do formularza</a>
@endsection
