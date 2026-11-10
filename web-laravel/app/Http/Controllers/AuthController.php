<?php

namespace App\Http\Controllers;

use App\Models\petugas;
use Illuminate\Http\Request;

class AuthController extends Controller
{
    public function login(Request $request){
        return view('form-login',[
            'data-petugas'=>petugas::find()
        ]);
    }

    public function tambah(Request $request){
        return view('tambah-petugas');
    }

}
