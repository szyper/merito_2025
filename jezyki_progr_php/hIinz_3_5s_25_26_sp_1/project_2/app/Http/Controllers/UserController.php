<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class UserController extends Controller
{
    // wyświetlenie formularza
    public function showForm(Request $req){
        return view('form', [
            'name' => $req->name,
            'age' => $req->age
        ]);
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


        return view('result_form', [
            'name' => $req->name,
            'age' => $req->age
        ]);
    }

}
