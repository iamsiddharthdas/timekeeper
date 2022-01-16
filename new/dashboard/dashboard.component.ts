import { Component, OnInit } from '@angular/core';
import {FormBuilder, FormGroup} from '@angular/forms'
import { ApiService } from '../shared/api.service';
import { model } from './dashboard.model';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  formValue !: FormGroup;
  modelobj : model = new model();
  alldata !: any;
  showadd!: boolean;
  showupdate!: boolean;

  constructor(private formbuilder: FormBuilder,
    private api : ApiService) { }

  ngOnInit(): void {
    this.formValue=this.formbuilder.group({
      projectid : [''],
      project : [''],
      task : [''],
      monday : [''],
      tuesday : [''],
      wednesday : [''],
      thursday : [''],
      friday : [''],
      saturday : [''],
      sunday : ['']
    })
    this.getalldata();
  }
  clickaddproject(){
    this.formValue.reset();
    this.showadd=true;
    this.showupdate=false;
  }

  postdetails(){
    this.modelobj.projectid = this.formValue.value.projectid;
    this.modelobj.project=this.formValue.value.project;
    this.modelobj.task=this.formValue.value.task;
    this.modelobj.monday=this.formValue.value.monday;
    this.modelobj.tuesday=this.formValue.value.tuesday;
    this.modelobj.wednesday=this.formValue.value.wednesday;
    this.modelobj.thursday=this.formValue.value.thursday;
    this.modelobj.friday=this.formValue.value.friday;
    this.modelobj.saturday=this.formValue.value.saturday;
    this.modelobj.sunday=this.formValue.value.sunday;

    this.api.post(this.modelobj)
    .subscribe(res=>{
      console.log(res);
      alert("details added")
      let ref=document.getElementById('cancel')
      ref?.click();
      this.formValue.reset();
      this.getalldata();
    },
      err=>{
      alert("Something went wrong")
    })
  }
  getalldata(){
    this.api.get()
    .subscribe(res=>{
      this.alldata=res;
    })
  }
  deletedata(row : any){
    this.api.delete(row.id)
    .subscribe(res=>{
      alert("data removed")
      this.getalldata();
    })
  }
  onedit(row: any){
    this.showadd=false;
    this.showupdate=true;
    this.modelobj.id = row.id;
    this.formValue.controls['projectid'].setValue(row.projectid);
    this.formValue.controls['project'].setValue(row.project);
    this.formValue.controls['task'].setValue(row.task);
    this.formValue.controls['monday'].setValue(row.monday);
    this.formValue.controls['tuesday'].setValue(row.tuesday);
    this.formValue.controls['wednesday'].setValue(row.wednesday);
    this.formValue.controls['thursday'].setValue(row.thursday);
    this.formValue.controls['friday'].setValue(row.friday);
    this.formValue.controls['saturday'].setValue(row.saturday);
    this.formValue.controls['sunday'].setValue(row.sunday);
  }
  updatedetails(){
    this.modelobj.projectid = this.formValue.value.projectid;
    this.modelobj.project=this.formValue.value.project;
    this.modelobj.task=this.formValue.value.task;
    this.modelobj.monday=this.formValue.value.monday;
    this.modelobj.tuesday=this.formValue.value.tuesday;
    this.modelobj.wednesday=this.formValue.value.wednesday;
    this.modelobj.thursday=this.formValue.value.thursday;
    this.modelobj.friday=this.formValue.value.friday;
    this.modelobj.saturday=this.formValue.value.saturday;
    this.modelobj.sunday=this.formValue.value.sunday;

    this.api.update(this.modelobj,this.modelobj.id)
    .subscribe(res=>{
      alert("Details Updated");
      let ref=document.getElementById('cancel')
      ref?.click();
      this.formValue.reset();
      this.getalldata();
    })

  }

}
