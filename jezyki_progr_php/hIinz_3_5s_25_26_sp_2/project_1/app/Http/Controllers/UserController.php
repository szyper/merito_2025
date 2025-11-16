<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class UserController extends Controller
{
    // wyświetlenie formularza
    public function showForm(Request $req)
    {
        return view('form', [
            'name' => $req->name,
            'age' => $req->age
        ]);
    }

    public function processForm(Request $req){
        $message = [
            'name' => $req->input('name'),
            'age' => $req->input('age')
        ];
        return view('result_form', $message);
    }
}
