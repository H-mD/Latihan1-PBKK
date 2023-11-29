<?php

namespace App\Controllers;

class Home extends BaseController
{
    public function index(): string
    {
        $data = [
            'title' => 'PPDB Online',
            'subtitle' => 'Home'
        ];
        return view('v_home', $data);
    }
}
