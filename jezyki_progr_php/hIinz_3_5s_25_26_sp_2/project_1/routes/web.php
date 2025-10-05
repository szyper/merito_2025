<?php

use App\Http\Controllers\ProfileController;
use Illuminate\Support\Facades\Route;

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

Route::get('/merito', function(){
    return 'test';
})->name("Merito");

Route::redirect('wsb', 'merito');

Route::get('merito_data', function(){
   //return view('merito_data');
    //return ['firstName' => 'Janusz', 'lastName' => 'Nowak'];
    return view('merito_data', ['firstName' => 'Janusz', 'lastName' => 'Nowak']);

});

Route::get('pages/{x}', function($x){
    $pages = [
        'about' => 'Strona Merito',
        'contact' => 'merito@wp.pl',
        'home' => 'Strona domowa'
    ];

    return $pages[$x];
});

Route::prefix('admin')->group(function(){
    Route::get('home/{name}', function($name){
        echo "Witaj $name na stronie administracyjnej";
    })->where('name' , '[A-Za-z]+');

    Route::get('users', function(){
        echo "<h3>Użytkownicy systemu</h3>";
    });
});


