<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class BladeController extends Controller
{
    public function index()
    {
        $title = 'Lista zwierząt';
        $animals = [
            ['id' => 1, 'name' => 'Janusz', 'surname' => 'Nowak'],
            ['id' => 2, 'name' => 'Anna', 'surname' => 'Pawlak'],
        ];
        return view('test', compact('title', 'animals'));
    }
}
