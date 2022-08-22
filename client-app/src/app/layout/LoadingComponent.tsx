import React from "react";
import { Dimmer, Loader } from "semantic-ui-react";

//? here mean is optional
interface Props{
    inverted?: boolean;
    content?:string;
}

export default function LoadingComponent({inverted=true,content='Loading...'}:Props){
    return (
        <Dimmer active={true} inverted={inverted}>
            <Loader content={content}/>
        </Dimmer>
    )
}