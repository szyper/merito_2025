<?php

use App\Http\Controllers\ProfileController;
use Illuminate\Support\Facades\Route;
use App\Http\Controllers\MeritoController;
use App\Http\Controllers\TestController;
use App\Http\Controllers\PageController;

Route::get('/', function () {
    return view('welcome');
});

Route::get('/dashboard', function () {
    return view('dashboard');
})->middleware(['auth', 'verified'])->name('dashboard');

Route::middleware('auth')->group(function () {
    Route::get('/profile', [ProfileController::class, 'edit'])->name('profile.edit');
    Route::patch('/profile', [ProfileController::class, 'update'])->name('profile.update');
    Route::delete('/profile', [ProfileController::class, 'destroy'])->name('profile.destroy');
});

require __DIR__.'/auth.php';

Route::get('merito', function(){
    return view('merito');
})->name('merito');

Route::redirect('/wsb', '/merito');

Route::get('merito_data/{test?}', function($test=null){
    //return ['name' => 'Janusz', 'surname' => 'Nowak'];
    return view('merito_data', ['name' => 'Janusz', 'surname' => 'Nowak']);
})->name('Główna strona Merito z danymi');

Route::get('pages/{x}', function($x){
    $pages = [
        'about' => 'Strona Merito',
        'contact' => 'merito@wp.pl',
        'home' => 'Strona domowa'
    ];

    return $pages[$x];
});

//Route::get("site", [\App\Http\Controllers\MeritoController::class, "index"]);
Route::get('/site', [MeritoController::class, 'index']);
//Route::get('/m', [MeritoController::class, 'show']);

Route::get('test', [TestController::class, 'test']);
Route::get('drives/{page}', [PageController::class, 'show']);

