import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import React from 'react';
import { useNavigate } from 'react-router-dom'
import './AuthPanels.css'

export function DefaultAuthPanel(props) {
    return <div className="auth-panel">
        <div className="auth-inner-panel">
            <div className="auth-logo-default">Auth Funcs</div>
            <button className="primary-button button" onClick={() => props.handleAuthPanel(1)}>SIGN UP</button>
            <button className="secondary-button button" onClick={() => props.handleAuthPanel(2)}>LOG IN</button>
        </div>
    </div>
}

export function LogInPanel(props)
{
    let navigate = useNavigate();

    return <div className="auth-panel">
        <div className="auth-inner-panel">
            <div className="auth-logo-login">Auth Funcs</div>
            <div className="input-field">User name</div>
            <div className="input-field">Password</div>
            <button className="primary-button button" 
                    onClick={() => navigate('/gallery')}>
                        LOG IN
            </button>
            <h5>Don't have an account? <a href onClick={() => props.handleAuthPanel(1)}>Sign Up</a></h5>
        </div>
    </div>
}

export function RegisterPanel(props)
{    
    let navigate = useNavigate();
    return <div className="auth-panel">
        <div className="auth-inner-panel">
            <div className="auth-logo-register">Auth Funcs</div>
            <Input icon="fa-user" type="text">User name</Input>
            <Input icon="fa-at" type="email">Email</Input>
            <Input icon="fa-lock" type="password">Password</Input>
            <Input icon="fa-lock" type="password">Confirm password</Input>
            <button type='submit' className="primary-button button" 
                onClick={() => {
                    navigate("/home")}}>SIGN UP</button>
            <h5>Already have an account? <a href onClick={() => props.handleAuthPanel(2)}>Log In</a></h5>
        </div>
    </div>
}

function Input(props) {
    return <div className="input-field">
        <i className={"fa-solid " + props.icon} />
        <input className='input-field-box' type={props.type} placeholder={props.children}></input>
    </div>
}