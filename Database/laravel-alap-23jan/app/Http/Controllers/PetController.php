<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Http\Resources\petResource;
use App\Models\Pets;
use App\Http\Requests\PetRequest;
use Illuminate\Support\Facades\Hash;

class PetController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $data = Pets::all();
        return userResource::collection($data);
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(PetRequest $request)
    {
        //$newpet = new Pet();
        //$newpet->petname = $request->validated()['username'];
        //$newpet->save();
        //return $newpet;
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        $data = Pet::findOrFail('id', $id);
        return $data;
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, $id)
    {
        
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        $data = Pet::findOrFail('id', $id)->delete();
    }
}
