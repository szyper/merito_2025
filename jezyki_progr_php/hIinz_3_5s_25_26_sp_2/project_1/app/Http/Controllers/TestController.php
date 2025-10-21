<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class TestController extends Controller
{
    public function index()
    {
        //return 'kontroler';
        return ['site' => 'Merito.edu.pl', 'city' => 'Poznań'];
    }
}
