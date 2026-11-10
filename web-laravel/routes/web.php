<?php

use App\Http\Controllers\AuthController;
use Illuminate\Support\Facades\Route;

Route::get('/', function () {
    return view('form-login');
});

Route::get('induk',[AuthController::class,'login']);