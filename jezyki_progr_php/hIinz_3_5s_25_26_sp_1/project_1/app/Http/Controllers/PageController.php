<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class PageController extends Controller
{
    public function show($drive){
//        $drives = [
//            'fdd' => 'Dyskietka',
//            'hdd' => 'Dysk HDD',
//            'ssd' => 'Dysk SSD',
//        ];

        $drives = match($drive){
            'fdd' => 'Dyskietka',
            'hdd' => 'Dysk HDD',
            'ssd' => 'Dysk SSD',
            default => 'Błędna wartość'
        };
        return $drives;
    }
}
