<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class UserController extends Controller
{
    // wyświetlenie formularza
//    public function showForm(Request $req){
//        return view('form', [
//            'name' => $req->name,
//            'age' => $req->age
//        ]);
//    }

    public function showForm(){
        return view('form');
    }

    public function processForm(Request $req){
//        $name = $req->input('name');
//        $age = $req->input('age');
//
//        $message = [
//            'name' => $name,
//            'age' => $age
//        ];
//
//        return view('result_form', $message);

        // walidacja formularza
//        $validate = $req->validate([
//            'name' => 'required|min:2|max:8',
//            'age' => 'required|integer|min:2|max:140'
//        ]);

        $validate = $req->validate([
            'name' => 'required|min:2|max:8',
            'age' => 'integer|min:2|max:140'
        ],[
//            'name.required' => 'Pole imię jest wymagane',
            'name.min' => 'Imię musi mieć co najmniej :min znaki',
            'name.max' => 'Imię musi mieć maksymalnie :max znaków',
//            'age.required' => 'Pole jest wymagane',
            'age.min' => 'Wiek nie może być mniejszy niż :min',
            'age.max' => 'Wiek nie może być większy niż :max',
            'age.integer' => 'Wiek musi być liczbą całkowitą'
        ]);

        // jeśli walidacja powiedzie się
        return view('result_form', [
            'name' => $validate['name'],
            'age' => $validate['age']
        ]);
    }

}
