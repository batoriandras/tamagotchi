<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Http\Resources\petResource;
use App\Models\Pets;
use App\Http\Requests\PetRequest;
use App\Http\Requests\PetStatRequest;
use Illuminate\Support\Facades\Auth;

class PetController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $data = auth()->user()->UsersPets;
        return petResource::collection($data);
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(PetRequest $request)
    {
        $newpet = new Pets();
        $newpet->users_id = Auth::id();
        $newpet->animals_id = $request->validated()['animals_id'];
        $newpet->petname = $request->validated()['petname'];
        /*$newpet->hungerdate = datetime('Y-m-d H:i:s');*/
        $newpet->hunger = 100;
        $newpet->thirst = 100;
        $newpet->mood = 100;
        $newpet->fatigue = 80;
        $newpet->birth = date('Y-m-d');
        $newpet->save();
        return new petResource($newpet);
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        $data = Pets::findorFail($id);
        return new petResource($data);
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(PetRequest $request, $id)
    {
        $data = Pets::findOrFail($id);
        $data->petname = $request->validated()['petname'];
        /*$data->hungerdate = dateTime('Y-m-d H:i:s');*/
        $data->save();
        return new petResource($data);
    }

    public function updateStat(PetStatRequest $request, $id)
    {
        $data = Pets::findOrFail($id);
        $data->hunger = $request->validated()['hunger'];
        $data->thirst = $request->validated()['thirst'];
        $data->mood = $request->validated()['mood'];
        $data->fatigue = $request->validated()['fatigue'];
        $data->save();
        return new petResource($data);
    }


    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        $data = Pets::findOrFail($id)->delete();
    }
}
