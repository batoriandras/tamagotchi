<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Http\Resources\animalResource;
use App\Http\Requests\AnimalRequest;
use App\Models\Animals;

class AnimalController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $data = Animals::all();
        return animalResource::collection($data);
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(AnimalRequest $request)
    {
        $newanimal = new Animals();
        $newanimal -> animaltype = $request->validated()['animaltype'];
        $newanimal -> animalimg = $request->validated()['animalimg'];
        $newanimal -> save();
        return new animalResource($newanimal);
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        $data = Animals::findorfail($id);
        return new animalResource($data);
    }
}
