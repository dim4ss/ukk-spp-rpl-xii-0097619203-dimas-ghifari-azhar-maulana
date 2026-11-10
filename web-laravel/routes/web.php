<?php

use App\Http\Controllers\AuthController;
use Illuminate\Support\Facades\Route;

Route::get('/', function () {
    return view('form-login');
});

Route::get('form-login',[AuthController::class,'login']);
Route::get('tambah-petugas/create',[AuthController::class,'tambah']);