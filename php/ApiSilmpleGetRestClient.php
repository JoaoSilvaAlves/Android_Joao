<?php

class ApiSimpleGetRestClient
{
    private $hostUrl = '';
    /*
     * Contructor
     */
    public function ApiSimpleGetRestClient($host, $user='', $password='')
    {
        $this->hostUrl = $host.'/';
        $this->userAuth = $user;
        $this->pwdAuth = $password;
    }
    /*
     * Method : GET
     * $url_entity : table corresponding (role, person, classe ou EnseigneA)
     */
    public function get($url_entity){
        $url=  $this->hostUrl.$url_entity;
        $curl = curl_init();
        
        $http_message = self::send_request($curl, $url);
        return $http_message;
    }
    
    /*
     * Send the request and return the result
     */
    private function send_request($curl, $url)
    {
        curl_setopt($curl, CURLOPT_URL, $url);
        curl_setopt($curl, CURLOPT_RETURNTRANSFER, true);
        $result = curl_exec($curl);
        curl_close($curl);
        return $result;
    }
}