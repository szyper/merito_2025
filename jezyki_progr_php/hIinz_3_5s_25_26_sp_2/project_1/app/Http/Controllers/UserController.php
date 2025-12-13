<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class UserController extends Controller
{
    // wyświetlenie formularza
    public function showForm(Request $req)
    {
//        return view('form', [
//            'name' => $req->name,
//            'age' => $req->age
//        ]);

        return view('form');
    }

    public function processForm(Request $req){
        // walidacja
        $validated = $req->validate([
            'name' => 'required|min:2|max:8',
            'age' => 'required|min:0|max:140|integer'
        ],[
            'name.required' => 'Pole imię jest wymagane',
            'name.min' => 'Imię musi mieć co najmniej :min znaki',
            'name.max' => 'Imię może mieć maksymalnie :max znaków',
//            'age.required' => 'Pole wiek jest wymagane',
            'age.min' => 'Wiek nie może być mniejszy niż :min',
            'age.max' => 'Wiek nie może być większy niż :max',
            'age.integer' => 'Wiek musi być liczbą całkowitą',
        ]);


        // jeśli walidacja będzie prawidłowa
        return view('result_form', [
            'name' => $validated['name'],
            'age' => $validated['age'],
        ]);
    }
}
